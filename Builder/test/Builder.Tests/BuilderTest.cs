using System;
using Xunit;

namespace Builder.Tests
{
    public class BuilderTest
    {
        [Fact]
        public void TestConcreteBuilder1()
        {
            var client = new Client(new ConcreteBuilder1());
            var product = client.Build();

            Assert.Equal("ConcreteBuilder1.BuildPartA", product.Value1);
            Assert.Equal("ConcreteBuilder1.BuildPartB", product.Value2);
        }

        [Fact]
        public void TestConcreteBuilder2()
        {
            var client = new Client(new ConcreteBuilder2());
            var product = client.Build();

            Assert.Equal("ConcreteBuilder2.BuildPartA", product.Value1);
            Assert.Equal("ConcreteBuilder2.BuildPartB", product.Value2);
        }
    }
}
