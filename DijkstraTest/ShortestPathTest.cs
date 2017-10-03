using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dijkstra;

namespace DijkstraTest
{
    [TestClass]
    class ShortestPathTest
    {
        [TestMethod]
        public void TestShortestPath()
        {
            ShortestPathGraph g = new ShortestPathGraph();
            g.AddEdge(1, 2);
        }
    }
}
