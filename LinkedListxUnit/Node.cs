using System;
using LinkedListxUnit.Interfaces;

namespace LinkedListxUnit
{
    public class Node : INode
    {
        public Node Next { get; set; }
        public object Data { get; set; }
    }
}