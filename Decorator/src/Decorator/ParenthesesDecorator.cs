using System;

namespace Decorator
{
    public class ParenthesesDecorator : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            this.State = $"({base._component.State})";
        }
    }
}