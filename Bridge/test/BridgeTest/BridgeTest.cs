using System;
using Xunit;
using Bridge;

namespace BridgeTest
{
    public class BridgeTest
    {
        [Fact]
        public void MainTest()
        {
            Abstraction abstraction = new Abstraction();
            abstraction.Implementor = new ConcreteImplementorA();
            var result1 = abstraction.AbstactOperation();
            Assert.Equal("ConcreteImplementorA", result1);
            // change the underlaying implementor, interace of abstraction (bridge) isn't changed
            abstraction.Implementor = new ConcreteImplementorB();
            var result2 = abstraction.AbstactOperation();
            Assert.Equal("ConcreteImplementorB", result2);
        }
    }
}
