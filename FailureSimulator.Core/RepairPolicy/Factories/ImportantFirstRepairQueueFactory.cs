using FailureSimulator.Core.RepairPolicy.Queues;

namespace FailureSimulator.Core.RepairPolicy.Factories
{
    public class ImportantFirstRepairQueueFactory : BaseRepqairQueueFactory
    {
        public override IRepairQueue CreateQueue()
        {
            return new ImportantFirstRepairQueue();
        }

        public override string Name => "Сначала важные";
    }
}