using System;

namespace Bridge
{
    public class Abstraction
    {
        private readonly string DEFAULT_LABEL = "";
        private Implementor implementor;

        public Implementor Implementor { set => implementor = value; protected get => implementor; }

        public string AbstactOperation()
        {
            Implementor.Operation(DEFAULT_LABEL);
            Implementor.OperationTwo();
            return implementor.GetState();
        }
    }
}
