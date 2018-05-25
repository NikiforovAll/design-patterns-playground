using System;
using Xunit;
using Decorator;
using Xunit.Abstractions;

namespace Decorator.Tests
{
    public class DecoratorTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public DecoratorTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

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
            Assert.Equal("*", components[0].State);
            Assert.Equal("(*)", components[1].State);
            Assert.NotNull((components[1] as Decorator).GetComponent());
            Assert.Equal("(*).", componentToTest.State);
        }
    }
}
