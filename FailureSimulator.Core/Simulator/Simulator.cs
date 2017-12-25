using System;
using System.Collections.Generic;
using System.Linq;
using FailureSimulator.Core.AbstractPathAlgorithms;
using FailureSimulator.Core.Graph;
using FailureSimulator.Core.Simulator.Report;

namespace FailureSimulator.Core.Simulator
{
    public class Simulator
    {
        private IPathFinder  _pathFinder;
        private Graph.Graph _graph;
        private Random _rnd;
        private Distribution _distribution;
        private SimulationSettings _settings;

        public Simulator(Graph.Graph graph, IPathFinder pathFinder, SimulationSettings settings)
        {
            _pathFinder = pathFinder;
            _graph = graph;
            _rnd = new Random();
            _distribution = new Distribution(_rnd);

            _settings = settings;
        }

        public SimulationReport Simulate(Vertex start, Vertex end)
        {
            var failureTimes = new List<double>();
            var cGraph = new ComputationGraph(_graph, _pathFinder, start, end);
            
            for(int i = 0; i < _settings.NumRuns; i++)
                failureTimes.Add(RunIteration(cGraph));

            // Формирование отчета
            var report = new SimulationReport();
            report.MinFailureTime = failureTimes.Min();
            report.MaxFailureTime = failureTimes.Max();
            report.AverageFailureTime = failureTimes.Average();
            // TODO: AverageRepairTime
            // TODO: AvailabilityRate
            report.Pathes = cGraph.Pathes;
            // TODO: Вероятность безотказной работы системы
            // TODO: Гррафик зависимости безотказной работы системы от времени Pc(t)
            report.FailureBarChart = ToHistogram(failureTimes, _settings.BarChartCount, report.MinFailureTime, report.MaxFailureTime);
            // TODO: RepairBarChart
            // TODO: TimeDiagram


            return report;
        }


        // Симлуляция одной итерации до отказа
        private double RunIteration(ComputationGraph cGraph)
        {
            double t = 0;

            do
            {
                // Генерируем отказ элемента
                var element = GetFailedElement(cGraph);
                double tFail = GetFailureTime(element);
                t += tFail;
                element.IsDestroyed = true;
            }
            while (cGraph.IsPathExists());

            return t;
        }


        /// <summary>
        /// Генерирует, какой элемент отказал
        /// </summary>
        /// <returns></returns>
        private DestroyableElement GetFailedElement(ComputationGraph graph)
        {
            double rand = _rnd.NextDouble() * GetTotalFailIntensity(graph);
            double sum = 0;

            foreach (var destroyableElement in graph.Elements)
            {
                sum += destroyableElement.Value.FailIntensity;
                if (sum > rand)
                    return destroyableElement.Value;
            }

            return graph.Elements.Last().Value;
        }


        // Возвращает суммарную интенсивность отказов не отказавших
        // элементов
        private double GetTotalFailIntensity(ComputationGraph graph)
        {
            double sum = 0;

            foreach (var destroyableElement in graph.Elements)
            {
                if (!destroyableElement.Value.IsDestroyed)
                    sum += destroyableElement.Value.FailIntensity;
            }

            return sum;
        }

        // Генерация времени отказал элемента
        private double GetFailureTime(DestroyableElement element)
        {
            return _distribution.Exponential(element.FailIntensity);
        }


        /// <summary>
        /// Преобразует массив данных в гистограмму
        /// </summary>
        /// <param name="data">Исходные данные</param>
        /// <param name="numBars">Число столбцов на гистограмме</param>
        /// <param name="min">Если минимальное значение данных уже найдено где-то ранее, можно использовать его для оптимизации</param>
        /// <param name="max">Если максимальное значение данных уже найдено где-то ранее, можно использовать его для оптимизации</param>
        /// <returns></returns>
        private Point[] ToHistogram(List<double> data, int numBars, double? min = null, double? max = null)
        {
            var hist = new Point[numBars];

            // Вычисляем ширину интервала
            double _min = min ?? data.Min();
            double _max = max ?? data.Max();
            double intervalPerBar = (_max - _min) / numBars;

            // Заполняем в качестве x-меток середины интервалов
            for (int i = 0; i < numBars; i++)
                hist[i].X = (i * intervalPerBar) + _min;

            // Подсчитываем частоты
            foreach (var d in data)
            {
                int index = (int)((d - _min) / intervalPerBar);
                hist[index].Y++;
            }

            return hist;
        }
    }
}