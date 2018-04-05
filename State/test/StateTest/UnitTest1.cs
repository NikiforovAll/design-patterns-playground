using System;
using Xunit;
using State;

namespace StateTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var ctx = new StateClient();
            ctx.State = new StateOne(ctx);
            Assert.Equal("StateOne", ctx.State.GetType().Name);
            ctx.Process();
            Assert.Equal("StateTwo", ctx.State.GetType().Name);
            ctx.Process();
            ctx.Process();
            Assert.Equal("StateOne", ctx.State.GetType().Name);
        }
    }
}
