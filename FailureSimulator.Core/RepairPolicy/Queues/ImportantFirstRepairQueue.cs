using FailureSimulator.Core.DataStruct;
using FailureSimulator.Core.Simulator;

namespace FailureSimulator.Core.RepairPolicy.Queues
{
    /// <summary>
    /// Очередь, организующая восстановление в первую очередь важных элементов
    /// </summary>
    public class ImportantFirstRepairQueue : Heap<RepairTask>, IRepairQueue
    {
        public ImportantFirstRepairQueue() : base(new ImportanFirstComparer()) { }
    }

    class ImportanFirstComparer : IHeapPriorityComparer<RepairTask>
    {
        public bool IsHeaped(RepairTask parent, RepairTask child)
        {
            return parent.Element.EncountsCount > child.Element.EncountsCount;
        }
    }
}