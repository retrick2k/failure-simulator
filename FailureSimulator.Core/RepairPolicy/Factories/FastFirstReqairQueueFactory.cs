using FailureSimulator.Core.RepairPolicy.Queues;

namespace FailureSimulator.Core.RepairPolicy.Factories
{
    public class FastFirstReqairQueueFactory : BaseRepqairQueueFactory
    {
        public override IRepairQueue CreateQueue()
        {
            return new FastFirstRepairQueue();
        }

        public override string Name => "Сначала быстро восстановимые";        
    }
}