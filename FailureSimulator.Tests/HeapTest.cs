using System;
using FailureSimulator.Core.DataStruct;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailureSimulator.Tests
{
    [TestClass]
    public class HeapTest
    {
        [TestMethod]
        public void AddElement()
        {
            var heap = new Heap<int>(new MinPriorityComparer<int>());
            heap.Add(3);
            heap.Add(2);
            heap.Add(1);

            Assert.AreEqual(1, heap.First);
        }

        [TestMethod]
        public void CreateFromElements()
        {
            int[] array = new int[]{4, 1, 3, 0, 5};
            var heap = new Heap<int>(new MinPriorityComparer<int>());

            Assert.AreEqual(0, heap.First);
        }

        [TestMethod]
        public void RemoveElementsd()
        {
            int[] array = new int[] { 4, 1, 3, 0, 5 };
            var heap = new Heap<int>(new MinPriorityComparer<int>());

            Assert.AreEqual(0, heap.First);
            heap.Pop();
            Assert.AreEqual(1, heap.First);
            heap.Pop();
            Assert.AreEqual(3, heap.First);
            heap.Pop();
            Assert.AreEqual(4, heap.First);
            heap.Pop();
            Assert.AreEqual(5, heap.First);

            heap.Pop();
            Assert.ThrowsException<IndexOutOfRangeException>(() => heap.First);
            Assert.ThrowsException<IndexOutOfRangeException>(() => heap.Pop());
        }
    }
}