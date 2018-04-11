using System;
using Xunit;
using Observer;
using System.Collections.Generic;
using System.Linq;
namespace ObserverTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var subject = new ConcreteSubject();
            var observers = new[] { new ConcreteObserver(), new ConcreteObserver(), new ConcreteObserver() };
            foreach (var observer in observers)
            {
                subject.Attach(observer);
            }
            subject.SubjectState = "init";
            subject.Notify();
            Assert.All(observers, (el => Assert.Equal("init", el.State)));
            subject.SubjectState = "changed";
            subject.Notify();
            Assert.All(observers, (el => Assert.Equal("changed", el.State)));
        }
    }
}
