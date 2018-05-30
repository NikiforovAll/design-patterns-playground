namespace AbstractFactory
{
    public class ConcreteProductB2 : AbstractProductB
    {
        public override string MethodB()
        {
            return $"{this.GetType().FullName}";
        }
    }
}