using System;

namespace Decorator
{
    public abstract class Component
    {
        public abstract void Operation();
        public string State { get; set; }
    }
}
