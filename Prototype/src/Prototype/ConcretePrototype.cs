using System;

namespace Prototype
{
    public class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id)
        : base(id)
        {
        }

        // Returns a shallow copy

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }
    }

    public class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id)
        : base(id)
        {
        }

        // Returns a shallow copy

        public override Prototype Clone()
        {
            // we could vary the coping logic for each prototype; 
            var prototype = (Prototype)this.MemberwiseClone();
            prototype.Counter++;
            return prototype;
        }
    }
}