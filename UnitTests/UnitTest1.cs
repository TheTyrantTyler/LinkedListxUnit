using System;
using LinkedListxUnit;
using LinkedListxUnit.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        private IServiceCollection ServiceCollection { get; set; } = new ServiceCollection();
        private IServiceProvider GetNewServiceProvider => ServiceCollection.BuildServiceProvider();
        // private readonly LinkedList _sut;
        //private Mock<IConsoleOutput> ConsoleOutputMock;
        
        public UnitTest1()
        {
            ServiceCollection.AddTransient<ILinkedList, LinkedList>();
            ServiceCollection.AddSingleton<IConsoleOutput, ConsoleOutput>();
            // _sut = new LinkedList();
        }

        [Fact]
        public void TestMockingConcept()
        {
            var mockList = new Mock<IConsoleOutput>();
            mockList.Setup(p => p.Write("hello")); //.Equals("hello") ??
            
            var holder = new LinkedList(mockList.Object);
            holder.AddFirst("hello");
            Assert.Same(mockList, holder.GetData()); // ("hello", holder.GetData());

        }
        
        [Fact]
        public void LinkedListAddFirst()
        {
            var sp = GetNewServiceProvider;
            var service = sp.GetService<ILinkedList>();
            service.AddFirst("Hello");
            Assert.Same("Hello", service.GetData());
        }
    }
}