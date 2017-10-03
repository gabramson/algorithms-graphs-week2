using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dykstra;

namespace HeapTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MinHeap<int> heap = new MinHeap<int>();
            heap.Add(10, 4);
            heap.Add(5, 1);
            Assert.AreEqual(heap.RemoveMin(), (5,1));
        }
    }
}
