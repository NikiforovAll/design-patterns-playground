using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace TemlateMethod
{
    public abstract class AbstractClass
    {
        // TemplateMethod
        public int Process(IEnumerable<int> items)
        {
            return items
                .Where<int>(this.Filter)
                .Select(this.ProcessUnit)
                .Aggregate((item, acc) =>
                    {
                        acc += item;
                        return acc;
                    });
        }
        protected abstract bool Filter(int item);
        protected abstract int ProcessUnit(int i);
    }

    public class ConcreteProcessor1 : AbstractClass
    {
        protected override bool Filter(int item)
        {
            return item > 2;
        }

        protected override int ProcessUnit(int i)
        {
            return i * 2;
        }
    }
    public class ConcreteProcessor2 : AbstractClass
    {
        protected override bool Filter(int item)
        {
            return item > 0;
        }

        protected override int ProcessUnit(int i)
        {
            return i;
        }
    }
}
