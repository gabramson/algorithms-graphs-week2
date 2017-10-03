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
            Heap<int> heap = new Heap<int>();
            heap.Add(5, 1);
            Assert.AreEqual(heap.Remove(), (5,1));
        }
    }
}
