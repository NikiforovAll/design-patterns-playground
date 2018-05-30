namespace AbstractFactory
{
    public class ConcreteProductA2 : AbstractProductA
    {
        public override string MethodOnProductB(AbstractProductB b)
        {
            return $"{this.GetType().FullName}-{b.MethodB()}";
        }
    }
}