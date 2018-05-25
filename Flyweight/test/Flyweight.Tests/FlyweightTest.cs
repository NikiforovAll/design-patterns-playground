using System;
using Xunit;
using Flyweight;

namespace Flyweight.Tests
{
    public class FlyweightTest
    {
        [Fact]
        public void MainTest()
        {
            FlyweightFactory factory = new FlyweightFactory();
            var flyweights = new Flyweight[] {
                factory.GetFlyweight(Priority.Low),
                factory.GetFlyweight(Priority.Medium),
                factory.GetFlyweight(Priority.High),
                factory.GetUnsharedFlyweight(Priority.Low)
            };
            var results = new int[4];
            var i = 0;
            foreach (var flyweight in flyweights)
            {
                results[i++] = flyweight.Operation();
            }
            Assert.Equal(new int[]{2, 4, 9, 2}, results);
            var newContextFlyweight = factory.GetFlyweight(Priority.Low);
            Assert.Equal(1, newContextFlyweight.Operation());
            
        }
    }
}
