using System;

namespace LinkedListxUnit.Interfaces
{
    public interface ILinkedList
    {
        public void PrintAllNodes();
        public void AddLast(Object data);
        public void AddFirst(Object data);
        public Object GetData();
    }
}