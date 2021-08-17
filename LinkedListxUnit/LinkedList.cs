using System;
using LinkedListxUnit.Interfaces;

namespace LinkedListxUnit
{
    public class LinkedList : ILinkedList
    {
        private Node head;

        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

        public void AddFirst(Object data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            if (head == null)
            {
                head = toAdd;
                toAdd.next = null;
            }
            else
            {
                Node next = head;
                toAdd.next = next;
                head = toAdd;
            }

        }

        public void AddLast(Object data)
        {
            Node toAdd = new Node();
            toAdd.data = data;
            Node current = head;
            while (current != null)
            {
                if (current.next == null)
                {
                    current.next = toAdd;
                    break;
                }

                current = current.next;
            }
        }

    }
}