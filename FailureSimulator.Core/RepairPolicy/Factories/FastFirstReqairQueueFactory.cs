using FailureSimulator.Core.RepairPolicy.Queues;

namespace FailureSimulator.Core.RepairPolicy.Factories
{
    public class FastFirstReqairQueueFactory : IRepairFactory
    {
        public IRepairQueue CreateQueue()
        {
            return new FastFirstRepairQueue();
        }

        public string Name => "Сначала быстро восстановимые";
    }
}