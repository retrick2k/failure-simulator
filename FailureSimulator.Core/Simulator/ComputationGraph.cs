using System;
using System.Collections.Generic;
using System.Linq;
using FailureSimulator.Core.AbstractPathAlgorithms;
using FailureSimulator.Core.Graph;
using FailureSimulator.Core.Probability;

namespace FailureSimulator.Core.Simulator
{
    /// <summary>
    /// Эта структура хранит граф в том виде, который удобен для 
    /// имитационного моделирования
    /// </summary>
    public class ComputationGraph
    {
        private List<List<DestroyableElement>> _pathes;
        private Dictionary<IGraphUnit, DestroyableElement> _units;
        private Random _rnd;

        public ComputationGraph(Graph.Graph graph, IPathFinder pathFinder, GraphUnit startGraphUnit, GraphUnit endGraphUnit)
        {
            _pathes = new List<List<DestroyableElement>>();
            _units = new Dictionary<IGraphUnit, DestroyableElement>();
            _rnd = new Random();


            // Заполняем словарь элементами
            foreach (var vertex in graph.Vertex)
            {
                _units.Add(vertex, new DestroyableElement(vertex.FailIntensity, vertex.RepairIntensity));

                foreach (var edge in vertex.Edges)
                    _units.Add(edge, new DestroyableElement(edge.FailIntensity, edge.RepairIntensity));
            }

            var pathes = pathFinder.FindAllPathes(graph, startGraphUnit, endGraphUnit);                     

            // На основе путей, составляем пути из DestroyableElements, так же добавляя
            // ребра между вершинами, потому что они тоже могут отказывать
            foreach (var path in pathes)
            {
                var dPath = new List<DestroyableElement>();

                for (int i = 0; i < path.Count - 1; i++)
                {
                    var v1 = path[i];
                    var v2 = path[i + 1];
                    var edge = graph.GetEdge(v1, v2);   // Ребро гарантированно существует

                    dPath.Add(_units[v1]);
                    dPath.Add(_units[edge]);
                }

                // Добавляем последнюю вершину
                dPath.Add(_units[path[path.Count-1]]);
                
                _pathes.Add(dPath);
            }
        }


        /// <summary>
        /// Генерирует, какой элемент отказал
        /// </summary>
        /// <returns></returns>
        public DestroyableElement GetFailedElement()
        {
            double rand = _rnd.NextDouble() * GetTotalFailIntensity();
            double sum = 0;

            foreach (var destroyableElement in _units)
            {
                sum += destroyableElement.Value.FailIntensity;
                if (sum > rand)
                    return destroyableElement.Value;
            }

            return _units.Last().Value;
        }


        /// <summary>
        /// Проверяет наличие пути между начальной  и конечной
        /// вершиной
        /// </summary>
        /// <returns></returns>
        public bool IsPathExists()
        {
            foreach (var path in _pathes)
            {
                bool isPathOk = true;
                foreach (var destroyableElement in path)
                {
                    if (destroyableElement.IsDestroyed)
                        isPathOk = false;
                }

                if (isPathOk)
                    return true;
            }

            return false;
        }


        // Возвращает суммарную интенсивность отказов не отказавших
        // элементов
        private double GetTotalFailIntensity()
        {
            double sum = 0;

            foreach (var destroyableElement in _units)
            {
                if (!destroyableElement.Value.IsDestroyed)
                    sum += destroyableElement.Value.FailIntensity;
            }

            return sum;
        }
    }

    /// <summary>
    /// Элемент, который может выходить из строя и восстанавливаться.
    /// Используется при расчете надежности
    /// </summary>
    public class DestroyableElement
    {
        /// <summary>
        /// Интенсивность отказов
        /// </summary>
        public double FailIntensity { get; protected set; }
       
        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        public double RepairIntensity { get; protected set; }

        /// <summary>
        /// В настоящий момент отказ
        /// </summary>
        public bool IsDestroyed { get; protected set; }


        /// <summary>
        /// Оригинальный элемент, на основе которого был сделан DestroyableElement
        /// </summary>
        //public IGraphUnit Data { get; set; }

        /*public DestroyableElement(IGraphUnit unit)
        {
            //Data = unit;

            FailIntensity = unit.FailIntensity;
            RepairIntensity = unit.RepairIntensity;
        }*/

        public DestroyableElement(double failIntensity, double repairIntensity)
        {
            FailIntensity = failIntensity;
            RepairIntensity = repairIntensity;
        }
    }   

}