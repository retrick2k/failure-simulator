using FailureSimulator.Core.RepairPolicy.Queues;

namespace FailureSimulator.Core.RepairPolicy.Factories
{
    public class LifoRepairQueueFactory : BaseRepqairQueueFactory
    {
        public override IRepairQueue CreateQueue()
        {
            return new LifoRepairQueue();
        }

        public override string Name => "LIFO";
    }
}