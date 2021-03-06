﻿namespace FailureSimulator.Core.Graph
{
    public interface IGraphUnit
    {
        string Name { get; }

        /// <summary>
        /// Интенсивность отказов
        /// </summary>
        double FailIntensity { get; set; }

        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        double RepairIntensity { get; set; }
    }
}