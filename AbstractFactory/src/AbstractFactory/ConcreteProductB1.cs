namespace AbstractFactory
{
    public class ConcreteProductB1 : AbstractProductB
    {
        public override string MethodB()
        {
            return $"{this.GetType().FullName}";
        }
    }
}