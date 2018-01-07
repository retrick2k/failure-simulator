using FailureSimulator.Core.RepairPolicy.Queues;

namespace FailureSimulator.Core.RepairPolicy.Factories
{
    /// <summary>
    /// Создает очередь с политикой FIFO
    /// </summary>
    public class FifoRepairQueueFactory : IRepairFactory
    {
        public IRepairQueue CreateQueue()
        {
            return new FifoRepairQueue();
        }

        public string Name => "FIFO";
    }
}