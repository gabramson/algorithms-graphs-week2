using System;
using System.Collections.Generic;
using System.Text;

namespace Dijkstra
{
    internal class Vertex
    {
        public int index { get; }
        public List<int> outNeighbors { get; }

        public Vertex(int myIndex)
        {
            index = myIndex;
            outNeighbors = new List<int>();
        }

        public void AddOutNeighbor(int neighborIndex)
        {
            outNeighbors.Add(neighborIndex);
        }
    }
}
