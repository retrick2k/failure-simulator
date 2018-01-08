using FailureSimulator.Core.RepairPolicy.Queues;

namespace FailureSimulator.Core.RepairPolicy.Factories
{
    /// <summary>
    /// Создает очередь с политикой FIFO
    /// </summary>
    public class FifoRepairQueueFactory : BaseRepqairQueueFactory
    {
        public override IRepairQueue CreateQueue()
        {
            return new FifoRepairQueue();
        }

        public  override string Name => "FIFO";
    }
}