using System.Collections.Generic;

namespace FailureSimulator.Core.AbstractPathAlgorithms
{
    /// <summary>
    /// Находит все пути на графе.
    /// Проверяет наличие хотя бы одного пути на изменившемся графе.
    /// </summary>
    public interface IPathFinder
    {
        /// <summary>
        /// Возвращает список всех возможных изначальных путей
        /// </summary>
        IReadOnlyList<IReadOnlyList<int>> AllPathes { get; }

        /// <summary>
        /// Остался ли хоть один путь
        /// </summary>
        /// <returns></returns>
        bool IsAnyPathAlive();
    }
}