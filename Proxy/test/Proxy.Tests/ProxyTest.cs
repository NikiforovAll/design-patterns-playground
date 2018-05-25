using System;
using Xunit;
using Proxy;
namespace Proxy.Tests
{
    public class ProxyTest
    {
        [Fact]
        public void MainTest_WithException()
        {
            var proxy = new Proxy.MathProxy();
            Assert.Equal(2, proxy.Multiply(1, 2));
            Assert.ThrowsAsync<InvalidOperationException>(testCode: async () => proxy.Divide(1, 0));
        }
    }
}
