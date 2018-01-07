using System;
using FailureSimulator.Core.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FailureSimulator.Tests
{
    [TestClass]
    public class HeapTest
    {
        [TestMethod]
        public void AddElement()
        {
            var heap = new Heap<int, MinPriorityComparer<int>>();
            heap.Add(3);
            heap.Add(2);
            heap.Add(1);

            Assert.AreEqual(1, heap.Top);
        }

        [TestMethod]
        public void CreateFromElements()
        {
            int[] array = new int[]{4, 1, 3, 0, 5};
            var heap = new Heap<int, MinPriorityComparer<int>>(array);

            Assert.AreEqual(0, heap.Top);
        }

        [TestMethod]
        public void RemoveElementsd()
        {
            int[] array = new int[] { 4, 1, 3, 0, 5 };
            var heap = new Heap<int, MinPriorityComparer<int>>(array);

            Assert.AreEqual(0, heap.Top);
            heap.RemoteTop();
            Assert.AreEqual(1, heap.Top);
            heap.RemoteTop();
            Assert.AreEqual(3, heap.Top);
            heap.RemoteTop();
            Assert.AreEqual(4, heap.Top);
            heap.RemoteTop();
            Assert.AreEqual(5, heap.Top);

            heap.RemoteTop();
            Assert.ThrowsException<IndexOutOfRangeException>(() => heap.Top);
            Assert.ThrowsException<IndexOutOfRangeException>(() => heap.RemoteTop());
        }
    }
}