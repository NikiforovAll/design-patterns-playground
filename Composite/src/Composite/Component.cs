using System;

namespace Composite
{
    public abstract class Component
    {
        public string Name { get; set; }

        public abstract int GetValue();
    }
}
