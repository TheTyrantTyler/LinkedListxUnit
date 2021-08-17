using System;

namespace LinkedListxUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            LinkedList myList1 = new LinkedList();

            myList1.AddFirst("Hello");
            myList1.AddLast("Magical");
            myList1.AddLast("World");
            myList1.printAllNodes();
            
        }
    }
}