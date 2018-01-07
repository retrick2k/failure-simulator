using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using FailureSimulator.Core.AbstractPathAlgorithms;
using FailureSimulator.Core.DataStruct;
using FailureSimulator.Core.Graph;
using FailureSimulator.Core.RepairPolicy;
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


            for (int i = 0; i < _settings.NumRuns; i++)
            {
                cGraph.Reset();
                double t = RunIteration(cGraph);

                // Все, что больше MaxTime - мусор
                if(t <= _settings.MaxTime)
                    failureTimes.Add(t);
            }

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
            // TODO: TimeDiagra


            return report;
        }

        // Симлуляция одной итерации до отказа (или истечения времени)
        private double RunIteration(ComputationGraph cGraph)
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

                    // Генерируем новый отказ
                    ev = GenerateFailureEvent(cGraph, t);
                    heap.Add(ev);
                }
                else
                {
                    ev.Element.IsDestroyed = false;
                    freeWorkers++;
                }

                // Начинаем восстанвливать
                while (freeWorkers > 0 && repairQueue.Count > 0)
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
                }
            }
            
            return t;
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


        // Генерирует очередное событие отказа
        private SimulationEvent GenerateFailureEvent(ComputationGraph cGraph, double t)
        {
            var element = GetFailedElement(cGraph);
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
            var hist = new Point[numBars+1];

            // Вычисляем ширину интервала
            double _min = min ?? data.Min();
            double _max = max ?? data.Max();
            double intervalPerBar = (_max - _min) / numBars;

            // Заполняем в качестве x-меток середины интервалов
            for (int i = 0; i < numBars + 1; i++)
            {
                hist[i] = new Point {X = (i * intervalPerBar) + _min};
            }

            // Подсчитываем частоты
            foreach (var d in data)
            {
                int index = 0;
                if (Math.Abs(intervalPerBar) > 0.001)
                    index = (int) ((d - _min) / intervalPerBar);
                else
                    index = 0;

                hist[index].Y++;
            }

            return hist;
        }
    }
}