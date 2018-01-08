using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Threading;
using FailureSimulator.Core.AbstractPathAlgorithms;
using FailureSimulator.Core.DataStruct;
using FailureSimulator.Core.Graph;
using FailureSimulator.Core.RepairPolicy;
using FailureSimulator.Core.Simulator.Report;

namespace FailureSimulator.Core.Simulator
{

    public class Simulator
    {

        private IPathFinder _pathFinder;
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
            var repairTimes = new List<double>();
            var cGraph = new ComputationGraph(_graph, _pathFinder, start, end);


            // Симуляция
            for (int i = 0; i < _settings.NumRuns; i++)
            {
                cGraph.Reset();
                var rep = RunIteration(cGraph);

                // Все, что больше MaxTime - мусор
                if (rep.FailureTime <= _settings.MaxTime)
                    failureTimes.Add(rep.FailureTime);

                repairTimes.AddRange(rep.RepairTimes);
            }



            // Формирование отчета
            var report = new SimulationReport();
            report.MinFailureTime = failureTimes.Min();
            report.MaxFailureTime = failureTimes.Max();
            report.AverageFailureTime = failureTimes.Average();
            report.AverageRepairTime = repairTimes.Count > 0 ? repairTimes.Average() : 0;
            report.AvailabilityRate = report.AverageFailureTime / (report.AverageFailureTime + report.AverageRepairTime);
            report.Pathes = cGraph.Pathes;
            // TODO: Вероятность безотказной работы системы
            // TODO: Гррафик зависимости безотказной работы системы от времени Pc(t)
            report.FailureBarChart = ToHistogram(failureTimes, _settings.BarChartCount, report.MinFailureTime, report.MaxFailureTime);

            if(repairTimes.Count > 0)
                report.RepairBarChart =  ToHistogram(repairTimes, _settings.BarChartCount);

            // Отдельный запуск для сохранения диаграммы восстановления
            cGraph.Reset();
            report.TimeDiagram = RunIteration(cGraph, true).TimeDiagram;


            return report;
        }

        // Симлуляция одной итерации до отказа (или истечения времени)
        private IterationReport RunIteration(ComputationGraph cGraph, bool saveTimeline = false)
        {
            /* Идея алгоритма
             *  Есть события (отказ или восстанолвение), которые
             *  хранятся в куче. На вершине кучи всегда самое ближайшее событие
             *  
             *  Есть заявки на восстановление, которые помещаются в очередь с 
             *  какой-то политикой
             *  
             *   - Генерируем событие отказа, помещаем его в кучу
             *   - Извлекаем из кучи очередное событие
             *      - Отказ:
             *          - Отказываем элемент
             *          - Помещаем заявку на восстановление в очередь
             *          - Генерируем новый отказ, помещаем в кучу
             *      - Восстановление
             *          - Восстанавливаем элемент
             *    
             *    - Каждый раз мы берем свободных воркеров и раздаем
             *    им задачи из очереди. Каждая задача становится событием
             *    восстановления через некоторое время
             */

            var repairTimeList = new List<double>();
            TimeDiagram diagram = null;

            if (saveTimeline)
            {
                diagram = new TimeDiagram();
                foreach (var element in cGraph.Elements)
                    diagram.Add(element.Value.Data, new TimeLine());
            }

            var heap = new Heap<SimulationEvent>(new MinPriorityComparer<SimulationEvent>());
            var repairQueue = _settings.RepairFactory.CreateQueue();

            double t = 0;
            int freeWorkers = _settings.RepairTeamsCount;

            // Генерируем первый отказ
            SimulationEvent ev = GenerateFailureEvent(cGraph, t);
            heap.Add(ev);

            while (cGraph.IsPathExists() && t < _settings.MaxTime)
            {

                ev = heap.Pop();
                t = ev.Time;

                if (ev.Type == EventType.FAILURE)
                {
                    ev.Element.IsDestroyed = true;

                    // Добавляем задачу в очередь на восстановление
                    if (_settings.IsRepair)
                        CreateRepairTask(ev, t, repairQueue);

                    // Сохраняем событие на диаграмме
                    if (saveTimeline)
                        SaveEvent(diagram, ev.Element, ElementState.FAILURE, t);
                    
                    ev = GenerateFailureEvent(cGraph, t);
                    heap.Add(ev);
                }
                else
                {
                    ev.Element.IsDestroyed = false;
                    freeWorkers++;

                    // Сохраняем событие на диаграмме
                    if (saveTimeline)
                        SaveEvent(diagram, ev.Element, ElementState.REPAIR, t);
                }

                // Начинаем восстанвливать
                while (freeWorkers > 0 && repairQueue.Count > 0 && _settings.IsRepair)
                {
                    var task = repairQueue.Pop();
                    ev = new SimulationEvent()
                    {
                        Element = task.Element,
                        Time = t + task.TimeToRepair,
                        Type = EventType.REPAIR
                    };
                    
                    heap.Add(ev);
                    freeWorkers--;

                    // Сохраняем статистику по восстановлению
                    repairTimeList.Add(task.TimeToRepair);
                }
            }

            return new IterationReport()
            {
                FailureTime = t,
                RepairTimes = repairTimeList,
                TimeDiagram = diagram
            };
        }


        // Создает новую заявку на восстановление
        private void CreateRepairTask(SimulationEvent ev, double t, IRepairQueue repairQueue)
        {
            var task = new RepairTask()
            {
                Element = ev.Element,
                FailTime = t,
                TimeToRepair = GetRepairTime(ev.Element)
            };

            repairQueue.Add(task);
        }


        // Добавляет новое событие на диаграмму
        private void SaveEvent(TimeDiagram diagram, DestroyableElement e, ElementState state, double t)
        {
            diagram[e.Data].Add(new StatePoint(){Time = t, State = state});
        }


        // Генерирует очередное событие отказа
        private SimulationEvent GenerateFailureEvent(ComputationGraph cGraph, double t)
        {
            var element = GetFailedElement(cGraph);
            if (element == null)
                return null;

            double tFail = GetFailureTime(element);
            t += tFail;

            return new SimulationEvent()
            {
                Time = t,
                Element = element,
                Type = EventType.FAILURE
            };
        }

        // Выбирает отказавший элемент
        private DestroyableElement GetFailedElement(ComputationGraph graph)
        {
            double rand = _rnd.NextDouble() * GetTotalFailIntensity(graph);
            double sum = 0;

            foreach (var destroyableElement in graph.Elements)
            {
                if (destroyableElement.Value.IsDestroyed)
                    continue;

                sum += destroyableElement.Value.FailIntensity;
                if (sum > rand)
                    return destroyableElement.Value;
            }

            return null;
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

        // Генерация времени восстановления
        private double GetRepairTime(DestroyableElement element)
        {
            return _distribution.Exponential(_settings.RepairIntensity);
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
            var hist = new Point[numBars + 1];

            // Вычисляем ширину интервала
            double _min = min ?? data.Min();
            double _max = max ?? data.Max();
            double intervalPerBar = (_max - _min) / numBars;

            // Заполняем в качестве x-меток середины интервалов
            for (int i = 0; i < numBars + 1; i++)
            {
                hist[i] = new Point { X = (i * intervalPerBar) + _min };
            }

            // Подсчитываем частоты
            foreach (var d in data)
            {
                int index = 0;
                if (Math.Abs(intervalPerBar) > 0.001)
                    index = (int)((d - _min) / intervalPerBar);
                else
                    index = 0;

                hist[index].Y++;
            }

            return hist;
        }
    }
}