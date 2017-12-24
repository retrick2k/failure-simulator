using System;
using System.Collections.Generic;
using System.Linq;
using FailureSimulator.Core.AbstractPathAlgorithms;
using FailureSimulator.Core.Graph;

namespace FailureSimulator.Core.Simulator
{
    public class Simulator
    {
        private IPathFinder  _pathFinder;
        private Graph.Graph _graph;
        private Random _rnd;
        private Distribution _distribution;
        private int _numRuns;

        public Simulator(Graph.Graph graph, IPathFinder pathFinder, int numRuns)
        {
            _pathFinder = pathFinder;
            _graph = graph;
            _rnd = new Random();
            _distribution = new Distribution(_rnd);

            _numRuns = numRuns;
        }

        public List<double> Simulate(Vertex start, Vertex end)
        {
            var failureTimes = new List<double>();
            var cGraph = new ComputationGraph(_graph, _pathFinder, start, end);
            
            for(int i = 0; i < _numRuns; i++)
                failureTimes.Add(RunIteration(cGraph));

            return failureTimes;
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
    }
}