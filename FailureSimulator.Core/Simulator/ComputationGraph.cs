using System;
using System.Collections.Generic;
using System.Linq;
using FailureSimulator.Core.AbstractPathAlgorithms;
using FailureSimulator.Core.Graph;

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

        public IReadOnlyDictionary<IGraphUnit, DestroyableElement> Elements => _units;

        public ComputationGraph(Graph.Graph graph, IPathFinder pathFinder, Vertex startVertex, Vertex endVertex)
        {
            _pathes = new List<List<DestroyableElement>>();
            _units = new Dictionary<IGraphUnit, DestroyableElement>();


            // Заполняем словарь элементами
            foreach (var vertex in graph.Vertex)
            {
                _units.Add(vertex, new DestroyableElement(vertex.FailIntensity, vertex.RepairIntensity));

                foreach (var edge in vertex.Edges)
                    _units.Add(edge, new DestroyableElement(edge.FailIntensity, edge.RepairIntensity));
            }

            var pathes = pathFinder.FindAllPathes(graph, startVertex, endVertex);                     

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

        public void Reset()
        {
            foreach (var destroyableElement in _units)
                destroyableElement.Value.IsDestroyed = false;
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
        public double FailIntensity { get; private set; }
       
        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        public double RepairIntensity { get; private set; }

        /// <summary>
        /// В настоящий момент отказ
        /// </summary>
        public bool IsDestroyed { get; set; }


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