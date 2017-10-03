using System;
using System.Collections.Generic;
using System.Text;

namespace Dykstra
{
    public class MinHeap<valueType>
    {
        private List<(int key, valueType value)> heapList;
        int heapSize = 0;

        private int ParentIndex(int pos)
        {
            return (pos + 1) / 2 - 1;
        }

        public MinHeap()
        {
            heapList = new List<(int key, valueType value)>();
        }

        public void Add(int key, valueType value)
        {
            int pos;
            heapSize += 1;
            heapList.Add((key, value));
            for (pos = heapSize-1; pos>0 && heapList[ParentIndex(pos)].key > key; pos = ParentIndex(pos))
            {
                heapList[pos] = heapList[ParentIndex(pos)];
            }
            heapList[pos] = (key, value);
        }

        public (int, valueType) RemoveMin()
        {
            (int key, valueType value) returnValue = heapList[0];
            heapList.RemoveAt(0);
            return (returnValue);
        }
    }
}
