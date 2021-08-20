using System;
using System.Security.Authentication.ExtendedProtection;
using LinkedListxUnit.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace LinkedListxUnit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<ILinkedList, LinkedList>();
            serviceCollection.AddSingleton<IConsoleOutput, ConsoleOutput>();
            var serviceProvider = serviceCollection.BuildServiceProvider();
            var myList1 = serviceProvider.GetService<ILinkedList>();
            myList1.AddFirst("Hello");
            myList1.AddLast("Magical");
            myList1.AddLast("World");
            myList1.PrintAllNodes();
            
        }
    }
}
