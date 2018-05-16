using System;

namespace Bridge
{
    public class ConcreteImplementorA : Implementor
    {
        public string State { get; private set; }

        public override string GetState()
        {
            return State;
        }

        public override void Operation(string parameter)
        {
            State += parameter + "ConcreteImplementor";
        }

        public override void OperationTwo()
        {
            State += "A";
        }
    }
}
