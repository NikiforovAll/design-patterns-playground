using System;
using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public class Composite : Component
    {
        private Func<int, int, int> _delegate = (_, __) => 0;

        public List<Component> Components { get; } = new List<Component>();


        public Composite SetDelegate(Func<int, int, int> func)
        {
            this._delegate = func;
            return this;
        }
        public Composite Add(Component component)
        {
            Components.Add(component);
            return this;
        }

        public Composite AddAll(List<Component> components)
        {
            Components.AddRange(components);
            return this;
        }

        public override int GetValue() => Components.Select(el => el.GetValue()).Aggregate((item, acc) => _delegate(acc, item));

        public Composite Remove(Component component)
        {
            Components.Remove(component);
            return this;
        }
    }
}