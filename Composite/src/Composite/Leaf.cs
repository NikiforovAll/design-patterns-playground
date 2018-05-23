using System;

namespace Composite
{
    public class Leaf : Component
    {
        public int Value { get; set; }

        public Leaf(int value)
        {
            Value = value;
        }
        public override int GetValue()
        {
            return Value;
        }
    }
}