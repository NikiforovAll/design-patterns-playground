using System;

namespace FactoryMethod
{
    public class ConcreteCreatorB : Creator
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
