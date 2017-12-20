using System.Collections.Generic;

namespace FailureSimulator.Core.AbstractPathAlgorithms
{
    public interface IShortestPathFinder
    {
        /// <summary>
        /// Находит кратчайший маршрут на графе
        /// </summary>
        /// <param name="graph">Граф</param>
        /// <param name="startVertex">Индекс начальной вершины</param>
        /// <param name="endVertex">Индекс конечной вершины</param>
        /// <returns>Список индексов вершин, составляющих путь. null, если путь не найден</returns>
        List<int> GetPath(ComputationGraph.ComputationGraph graph, int startVertex, int endVertex);
    }
}