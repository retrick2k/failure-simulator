using FailureSimulator.Core.RepairPolicy.Queues;

namespace FailureSimulator.Core.RepairPolicy.Factories
{
    public class LifoRepairQueueFactory : IRepairFactory
    {
        public IRepairQueue CreateQueue()
        {
            return new LifoRepairQueue();
        }

        public string Name => "LIFO";
    }
}