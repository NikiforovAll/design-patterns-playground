using System;
using Xunit;

namespace Singleton.Tests
{
    public class SingletonTest
    {
        [Fact]
        public void Test1()
        {
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();
            Assert.Same(s1, s2);
        }
    }
}
