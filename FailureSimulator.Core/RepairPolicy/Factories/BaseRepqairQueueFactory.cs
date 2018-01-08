namespace FailureSimulator.Core.RepairPolicy.Factories
{
    public abstract class BaseRepqairQueueFactory : IRepairFactory
    {
        public abstract IRepairQueue CreateQueue();

        public abstract string Name { get; }

        public override string ToString() => Name;
    }
}