using FailureSimulator.Core.RepairPolicy;
using FailureSimulator.Core.RepairPolicy.Factories;

namespace FailureSimulator.Core.Simulator
{
    /// <summary>
    /// Параметры симуляции и отчета
    /// </summary>
    public class SimulationSettings
    {
        /// <summary>
        /// Количество запусков моделирования
        /// </summary>
        public int NumRuns { get; set; } = 3000;

        /// <summary>
        /// Максимальное время одной итерации
        /// </summary>
        public double MaxTime { get; set; } = 10000;

        /// <summary>
        /// Количество столбцов на гистограммах
        /// </summary>
        public int BarChartCount { get; set; } = 100;

        /// <summary>
        /// Есть ли восстановление
        /// </summary>
        public bool IsRepair { get; set; } = true;

        /// <summary>
        /// Число ремонтных бригад
        /// </summary>
        public int RepairTeamsCount { get; set; } = 1;

        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        public double RepairIntensity { get; set; } = 0.1;

        public IRepairFactory RepairFactory { get; set; } = new FifoRepairQueueFactory();

        public static SimulationSettings Default => new SimulationSettings();
    }
}