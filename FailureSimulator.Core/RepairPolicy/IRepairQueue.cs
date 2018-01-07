using FailureSimulator.Core.Simulator;

namespace FailureSimulator.Core.RepairPolicy
{
    /// <summary>
    /// Очередь восстановления с какой-либо политикой
    /// </summary>
    public interface IRepairQueue
    {
        /// <summary>
        /// Добавить новую задачу в очередь
        /// </summary>
        /// <param name="task">Задача</param>
        void Add(RepairTask task);

        /// <summary>
        /// Получить следующую задачу без извлечения
        /// </summary>
        /// <returns></returns>
        RepairTask Peek();

        /// <summary>
        /// Получить и извлечь следующую задачу
        /// </summary>
        /// <returns></returns>
        RepairTask Pop();


        /// <summary>
        /// Количество заявок в очереди
        /// </summary>
        int Count { get; }
    
    }
}