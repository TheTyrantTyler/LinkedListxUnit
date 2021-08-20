using System.Collections.Generic;
using LinkedListxUnit.Interfaces;

namespace LinkedListxUnit
{
    public class LinkedList : ILinkedList
    {
        private Node head;
        private readonly IConsoleOutput _output;
            
        public LinkedList(IConsoleOutput output)
        {
            _output = output;

        }
        public void PrintAllNodes()
        {
            var current = head;
            while (current != null)
            {
                _output.Write(current.Data);
                current = current.Next;
            }
            
        }

        public object GetData()
        {
            var current = head;
            while (current != null)
            {
                _output.Write(current.Data);
                if (current.Next != null)
                {
                    current = current.Next;
                }
                else
                {
                    return current.Data;
                }
            }

            return default;
        }
        public void AddFirst(object data)
        {
            var toAdd = new Node();
            toAdd.Data = data;
            if (head == null)
            {
                head = toAdd;
                toAdd.Next = null;
            }
            else
            {
                var next = head;
                toAdd.Next = next;
                head = toAdd;
            }

        }

        public void AddLast(object data)
        {
            var toAdd = new Node();
            toAdd.Data = data;
            var current = head;
            while (current != null)
            {
                if (current.Next == null)
                {
                    current.Next = toAdd;
                    break;
                }

                current = current.Next;
            }
        }

    }
}