namespace FailureSimulator.Core.Graph
{
    public interface IGraphUnit
    {
        /// <summary>
        /// Интенсивность отказов
        /// </summary>
        double FailIntensity { get; }

        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        double RepairIntensity { get;  }
    }
}