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

        public ComputationGraph(Graph.Graph graph, IPathFinder pathFinder)
        {
        }
    }

    class DestroyableElement
    {
        /// <summary>
        /// Интенсивность отказов
        /// </summary>
        public float DestroyIntensity { get; set; }

        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        public float RepairIntensity { get; set; }

        /// <summary>
        /// Отвечает за генерацию случайных времен отказов по 
        /// заданному закону распределения
        /// </summary>
        public IDistribution DestroyDistribution { get; set; }

        /// <summary>
        /// Отвечает за генерацию случайных времен восстановления по 
        /// заданному закону распределения
        /// </summary>
        public IDistribution RepairDistribution { get; set; }

        /// <summary>
        /// В настоящий момент отказ
        /// </summary>
        public bool IsDestroyed { get; set; }
    }

    
}