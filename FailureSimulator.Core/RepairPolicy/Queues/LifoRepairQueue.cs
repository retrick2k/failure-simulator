using System.Collections.Generic;
using FailureSimulator.Core.Simulator;

namespace FailureSimulator.Core.RepairPolicy.Queues
{
    /// <summary>
    /// Очередь, которая организует ремонт в первую очердь последних откаазавших элементов
    /// </summary>
    public class LifoRepairQueue : IRepairQueue
    {
        private Stack<RepairTask> _stack;

        public LifoRepairQueue()
        {
            _stack = new Stack<RepairTask>();
        }

        public void Add(RepairTask task)
        {
            _stack.Push(task);
        }

        public RepairTask Peek()
        {
            return _stack.Peek();
        }

        public RepairTask Pop()
        {
            return _stack.Pop();
        }

        public int Count => _stack.Count;
    }
}