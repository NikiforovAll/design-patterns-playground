using System;
using Xunit;
using Decorator;

namespace Decorator.Tests
{
    public class DecoratorTest
    {
        [Fact]
        public void MainTest()
        {
            Component componentToTest;
            var components = new Component[] {new ConcreteComponent("*"), new ParenthesesDecorator(), (componentToTest = new DotDecorator())};
            
            for (int i = 1; i < components.Length; i++)
            {
                (components[i] as Decorator)?.SetComponent(components[i-1]);
            }
            componentToTest.Operation();

            Assert.Equal("(*).", componentToTest.State);
        }
    }
}
