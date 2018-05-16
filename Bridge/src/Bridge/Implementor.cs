namespace Bridge
{
    public abstract class Implementor
    {
        public abstract void Operation(string parameter);

        public abstract void OperationTwo();

        public abstract string GetState();
    }
}