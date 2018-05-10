using System;
using Xunit;
using Adapter;

namespace AdapterTest
{
    public class AdapterTest
    {
        [Fact]
        public void MainTest()
        {
            var legacyAdaptee = new Adaptee();
            var adapter = new ConcreteAdapter();
            // as you can see it is possible to change method signature in a various ways
            Assert.Equal(legacyAdaptee.ExternalRequest("default"),adapter.Request());

        }
    }
}
