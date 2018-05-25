using System;

namespace Decorator
{
    public abstract class Decorator : Component
    {
        protected Component _component;

        public void SetComponent(Component component)
        {
            this._component = component;
        }

        public Component GetComponent()
        {
            return _component;
        }
        
        public override void Operation()
        {
            _component?.Operation();
        }

    }
}