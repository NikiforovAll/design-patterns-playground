using System;
using System.Collections.Generic;
using Xunit;
using TemlateMethod;

namespace test
{
    public class SomeFixture : IDisposable
    {
        public IEnumerable<int> Items { get; }
        public SomeFixture()
        {
            Items = new [] { 1, 2, 3, 4, 5 };
        }
        public void Dispose()
        {
            // throw new NotImplementedException();
        }
    }
    public class UnitTest1: IClassFixture<SomeFixture>
    {
        private readonly SomeFixture _payloadSource;

        public UnitTest1(SomeFixture payloadSource)
        {
            this._payloadSource = payloadSource;
        }
        [Fact]
        public void Test_ConcreteProcessor1_Success()
        {
            var processor = new ConcreteProcessor1();
            int result = processor.Process(_payloadSource.Items);
            Assert.Equal(24, result);
        }
        [Fact]
        public void Test_ConcreteProcessor2_Success()
        {
            var processor = new ConcreteProcessor2();
            int result = processor.Process(_payloadSource.Items);
            Assert.Equal(15, result);
        }
    }
}
