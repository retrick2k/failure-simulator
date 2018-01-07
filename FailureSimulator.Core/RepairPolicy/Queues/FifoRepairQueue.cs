using System.Collections.Generic;
using FailureSimulator.Core.Simulator;

namespace FailureSimulator.Core.RepairPolicy.Queues
{
    /// <summary>
    /// Чинить элементы в порядке отказов
    /// </summary>
    public class FifoRepairQueue : IRepairQueue
    {
        private Queue<RepairTask> _queue;

        public FifoRepairQueue()
        {
            _queue = new Queue<RepairTask>();
        }

        public void Add(RepairTask task)
        {
            _queue.Enqueue(task);
        }

        public RepairTask Peek()
        {
            return _queue.Peek();
        }

        public RepairTask Pop()
        {
            return _queue.Dequeue();
        }

        public int Count => _queue.Count;
    }
}