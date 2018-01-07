using System;

namespace FailureSimulator.Core.Simulator
{
    /// <summary>
    /// Задача на восстановление
    /// </summary>
    public class RepairTask
    {     
        /// <summary>
        /// Отказавший элемент
        /// </summary>
        public DestroyableElement Element { get; set; }

        /// <summary>
        /// Время, когда произошел отказ
        /// </summary>
        public double FailTime { get; set; }

        /// <summary>
        /// Сколько времени требуется на восстановление
        /// </summary>
        public double TimeToRepair { get; set; }
    }
}