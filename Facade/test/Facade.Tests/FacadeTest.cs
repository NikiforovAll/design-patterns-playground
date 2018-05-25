using System;
using Xunit;
using Facade;

namespace Facade.Tests
{
    public class FacadeTest
    {
        [Fact]
        public void MainMethod()
        {
            var facade = new Facade();
            string [] result1 = facade.MethodA();
            string [] result2 = facade.MethodB();

            Assert.Equal("SubSystemA.MethodA", result1[0]);
            Assert.Equal("SubSystemB.MethodA", result1[1]);

            Assert.Equal("SubSystemA.MethodA", result2[0]);
            Assert.Equal("SubSystemA.MethodB", result2[1]);
            Assert.Equal("SubSystemB.MethodB", result2[2]);
        }
    }
}
