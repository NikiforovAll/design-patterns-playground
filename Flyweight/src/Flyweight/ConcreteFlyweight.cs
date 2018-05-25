using System;

namespace Flyweight
{
    //we could create multiple flyweights and init them based on type in Flyweight factory
    public class ConcreteFlyweight : Flyweight
    {
        public ConcreteFlyweight(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; private set;}

        public override int Operation()
        {
            return --Capacity;
        }
    }
}