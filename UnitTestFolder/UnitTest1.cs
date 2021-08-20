using LinkedListxUnit;
using Xunit;

namespace UnitTestFolder
{
    public class UnitTest1
    {
        private readonly LinkedList _sut;
        public UnitTest1()
        {
            _sut = new LinkedList();
        }

        [Fact]
        public void LinkedListAddFirst()
        {
            _sut.AddFirst("I'm the first test line!");
            Assert.Same("I'm the first test line!", _sut.getData());
        }
    }
}