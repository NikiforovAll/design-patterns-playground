using System;

namespace Decorator
{
    public class ConcreteComponent : Component
    {
        public ConcreteComponent(string value)
        {
            this.State = value;
        }
        public override void Operation()
        {
        }
    }
}