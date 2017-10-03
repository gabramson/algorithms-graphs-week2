using System;
using System.Collections.Generic;
using System.Text;

namespace Dykstra
{
    public class Heap<valueType>
    {
        private List<(int key, valueType value)> heapList;

        public Heap()
        {
            heapList = new List<(int, valueType)>();
        }

        public void Add(int key, valueType value)
        {
            heapList.Add((key: key, value: value));
        }

        public (int, valueType) Remove()
        {
            (int, valueType) returnValue = heapList[0];
            heapList.RemoveAt(0);
            return (returnValue);
        }
    }
}
