using FailureSimulator.Core.RepairPolicy.Queues;

namespace FailureSimulator.Core.RepairPolicy.Factories
{
    public class ImportantFirstRepairQueueFactory : IRepairFactory
    {
        public IRepairQueue CreateQueue()
        {
            return new ImportantFirstRepairQueue();
        }

        public string Name => "Сначала важные";
    }
}