using System;
using Xunit;
using AbstractFactory;

namespace AbstractFactory.Tests
{
    public class AbstractFactoryTest
    {
        [Fact]
        public void MainTestClient1()
        {
            var client = new Client(new ConcreteFactory1());
            Assert.Equal("AbstractFactory.ConcreteProductA1-AbstractFactory.ConcreteProductB1", client.Run());
        }

        [Fact]
        public void MainTestClient2()
        {
            var client = new Client(new ConcreteFactory2());
            Assert.Equal("AbstractFactory.ConcreteProductA2-AbstractFactory.ConcreteProductB2", client.Run());
        }
    }
}
