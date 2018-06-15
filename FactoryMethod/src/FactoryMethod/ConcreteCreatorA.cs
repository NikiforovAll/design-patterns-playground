using System;

namespace FactoryMethod
{
    public class ConcreteCreatorA : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
