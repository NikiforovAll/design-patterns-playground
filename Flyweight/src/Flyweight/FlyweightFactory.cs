using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class FlyweightFactory
    {
        // it is possible to include lazy initialization
        private IDictionary<Priority, Flyweight> _cache = new Dictionary<Priority, Flyweight>{
            [Priority.Low] = new ConcreteFlyweight((int)Priority.Low),
            [Priority.Medium] = new ConcreteFlyweight((int)Priority.Medium),
            [Priority.High] = new ConcreteFlyweight((int)Priority.High),
        };

        public Flyweight GetFlyweight(Priority priority)
        {
            return _cache[priority];
        }

        public Flyweight GetUnsharedFlyweight(Priority priority)
        {
            return new ConcreteFlyweight((int)priority);
        }

    }
}