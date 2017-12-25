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
        public int NumRuns { get; set; } = 1000; //TODO: 1000

        /// <summary>
        /// Количество столбцов на гистограммах
        /// </summary>
        public int BarChartCount { get; set; } = 10;


        public static SimulationSettings Default => new SimulationSettings();
    }
}