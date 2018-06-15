using System;
using Xunit;
using FactoryMethod;

namespace FactoryMethod.Tests
{
    public class FactoryMethodTest
    {
        [Fact]
        public void Test1()
        {
            var creator = new ConcreteCreatorA();
            var product = creator.CreateProduct();
            Assert.True(product is ConcreteProductA);
        }

        [Fact]
        public void Test2()
        {
            var creator = new ConcreteCreatorB();
            var product = creator.CreateProduct();
            Assert.True(product is ConcreteProductB);
        }
    }
}
