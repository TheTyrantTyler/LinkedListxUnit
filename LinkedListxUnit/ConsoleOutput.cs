using System;
using LinkedListxUnit.Interfaces;

namespace LinkedListxUnit
{
    public class ConsoleOutput : IConsoleOutput
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }

        public void Write(object msg)
        {
            Console.WriteLine(msg);
        }
    }
}