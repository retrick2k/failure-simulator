using System.Collections.Generic;
using FailureSimulator.Core.Graph;

namespace FailureSimulator.Core.AbstractPathAlgorithms
{
    /// <summary>
    /// Находит все пути на графе от одной вершине к другой
    /// </summary>
    public interface IPathFinder
    {
        /// <summary>
        /// Возвращает список всех путей от одной вершины до другой
        /// </summary>
        /// <param name="graph">Граф</param>
        /// <param name="start">Начальная вершина</param>
        /// <param name="end">Конечная вершина</param>
        /// <returns>Список путей; путь - список вершин</returns>
        IReadOnlyList<IReadOnlyList<GraphUnit>> FindAllPathes(Graph.Graph graph, GraphUnit start, GraphUnit end);

        /// <summary>
        /// Возвращает список всех путей от одной вершины до другой
        /// </summary>
        /// <param name="graph">Граф</param>
        /// <param name="start">Имя начальной вершина</param>
        /// <param name="end">Имя конечной вершина</param>
        /// <returns>Список путей; путь - список вершин</returns>
        IReadOnlyList<IReadOnlyList<GraphUnit>> FindAllPathes(Graph.Graph graph, string start, string end);
    }
}