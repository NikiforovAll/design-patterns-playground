using System;
using Xunit;
using Composite;
using System.Collections.Generic;
using Blocks = System.Collections.Generic.List<Composite.Component>;
namespace Composite.Tests
{
    public class CompositeTest
    {
        [Fact]
        public void MainTest()
        {
            Component root = new Composite()
                .AddAll(
                    new Blocks{
                        new Composite()
                            .AddAll(new Blocks{new Leaf(1), new Leaf(2)})
                            .SetDelegate((x,y)=> y-x),
                        new Composite()
                            .AddAll(new Blocks{new Leaf(1), new Leaf(2), new Leaf(3)})
                            .SetDelegate((x,y)=> x+y)
                    }
                )
                .SetDelegate((x, y) => x * y);

            Assert.Equal(-6, root.GetValue());
        }
    }
}
