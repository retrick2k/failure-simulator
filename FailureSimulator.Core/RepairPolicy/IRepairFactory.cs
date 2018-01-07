namespace FailureSimulator.Core.RepairPolicy
{
    public interface IRepairFactory
    {
        /// <summary>
        /// Создает очередь
        /// </summary>
        /// <returns></returns>
        IRepairQueue CreateQueue();

        /// <summary>
        /// Имя политики восстановления
        /// </summary>
        string Name { get; }
    }
}