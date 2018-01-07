using System.Collections.Generic;
using FailureSimulator.Core.DataStruct;
using FailureSimulator.Core.Simulator;

namespace FailureSimulator.Core.RepairPolicy.Queues
{
    /// <summary>
    /// Очередь, организующшая ремонт в первую очередь узлов, которые быстро починить
    /// </summary>
    public class FastFirstRepairQueue : Heap<RepairTask>, IRepairQueue
    {
        public FastFirstRepairQueue() : base(new FastFirstHeapComparer()) { }      
    }

    class FastFirstHeapComparer : IHeapPriorityComparer<RepairTask>
    {
        public bool IsHeaped(RepairTask parent, RepairTask child)
        {
            return parent.TimeToRepair < child.TimeToRepair;
        }
    }
}