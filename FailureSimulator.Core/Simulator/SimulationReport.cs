using System.Collections.Generic;
using FailureSimulator.Core.Graph;

namespace FailureSimulator.Core.Simulator
{
    /// <summary>
    /// Отчет симуляции
    /// </summary>
    public class SimulationReport
    {
        /// <summary>
        /// Минимальное время до отказа сети
        /// </summary>
        public double MinFailureTime { get; set; }

        /// <summary>
        /// Максимальное время до отказа сети
        /// </summary>
        public double MaxFailureTime { get; set; }

        /// <summary>
        /// Средняя наработка до отказа сети
        /// </summary>
        public double AverageFailureTime { get; set; }

        /// <summary>
        /// Среднее время восстановления отказа сети связи
        /// </summary>
        public double AverageRepairTime { get; set; }

        /// <summary>
        /// Коэффициент готовности
        /// </summary>
        public double AvailabilityRate { get; set; }

        /// <summary>
        /// Список путей
        /// </summary>
        public IReadOnlyList<IReadOnlyList<Vertex>> Pathes { get; set; }
        
        // Вероятность безотказной работы системы
        // Гррафик зависимости безотказной работы системы от времени Pc(t)
        // Гистограмма времен отказа сети связи
        // Гистограмма времен восстановления
        // Диаграмма восстановления
    }
}