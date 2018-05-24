using System;

namespace Decorator
{
    public class DotDecorator : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            this.State = $"{base.State}.";
        }
    }
}