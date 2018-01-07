using FailureSimulator.Core.Graph;

namespace FailureSimulator.Core.Simulator
{
    /// <summary>
    /// Элемент, который может выходить из строя и восстанавливаться.
    /// Используется при расчете надежности
    /// </summary>
    public class DestroyableElement
    {
        /// <summary>
        /// Интенсивность отказов
        /// </summary>
        public double FailIntensity { get; private set; }
       
        /// <summary>
        /// Интенсивность восстановления
        /// </summary>
        public double RepairIntensity { get; private set; }

        /// <summary>
        /// В настоящий момент отказ
        /// </summary>
        public bool IsDestroyed { get; set; }

        /// <summary>
        /// Число вхождений в путях
        /// </summary>
        public int EncountsCount { get; set; }

        /// <summary>
        /// Оригинальный элемент, на основе которого был сделан DestroyableElement
        /// </summary>
        public IGraphUnit Data { get; set; }


        public DestroyableElement(IGraphUnit unit)
        {
            Data = unit;

            FailIntensity = unit.FailIntensity;
            RepairIntensity = unit.RepairIntensity;
        }

        public override string ToString()
        {
            return $"{Data.ToString()}, Failed: {IsDestroyed}";
        }

        /*public DestroyableElement(double failIntensity, double repairIntensity)
        {
            FailIntensity = failIntensity;
            RepairIntensity = repairIntensity;
        }*/
    }
}