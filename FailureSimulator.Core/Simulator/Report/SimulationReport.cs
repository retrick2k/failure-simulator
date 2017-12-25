using System.Collections.Generic;
using FailureSimulator.Core.Graph;

namespace FailureSimulator.Core.Simulator.Report
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
        

        // TODO: Вероятность безотказной работы системы
        // TODO: Гррафик зависимости безотказной работы системы от времени Pc(t)

        /// <summary>
        /// Гистограмма отказов
        /// </summary>
        public Point[] FailureBarChart { get; set; }

        /// <summary>
        /// Гистограмма восстановления
        /// </summary>
        public Point[] RepairBarChart { get; set; }

        /// <summary>
        /// Диаграмма восстановления
        /// </summary>
        public TimeDiagram TimeDiagram { get; set; }
    }
}