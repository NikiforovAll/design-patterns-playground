using System;
using Xunit;

namespace Prototype.Tests
{
    public class PrototypeTest
    {
        [Fact]
        public void Test()
        {
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();

            Assert.Equal("I", c1.Id);
            Assert.Equal(0, c1.Counter);

            Assert.Equal("II", c2.Id);
            Assert.Equal(1, c2.Counter);
        }
    }
}
