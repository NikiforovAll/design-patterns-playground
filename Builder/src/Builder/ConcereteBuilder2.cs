using System;

namespace Builder
{
    public class ConcreteBuilder2 : Builder
    {
        Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Value1 = $"{nameof(ConcreteBuilder2)}.{nameof(BuildPartA)}";
        }

        public override void BuildPartB()
        {
            _product.Value2 = $"{nameof(ConcreteBuilder2)}.{nameof(BuildPartB)}";
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}