using System;
using System.Collections.Generic;
using System.Text;

namespace Dykstra
{
    public class MinHeap<valueType>
    {
        private List<(int key, valueType value)> heapList;

        public MinHeap()
        {
            heapList = new List<(int key, valueType value)>();
        }

        public void Add(int key, valueType value)
        {
            heapList.Add((key: key, value: value));
        }

        public (int, valueType) RemoveMin()
        {
            (int key, valueType value) returnValue = heapList[0];
            heapList.RemoveAt(0);
            return (returnValue);
        }
    }
}
