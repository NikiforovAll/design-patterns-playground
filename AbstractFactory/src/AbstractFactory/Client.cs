namespace AbstractFactory
{
    public class Client
    {
        public AbstractProductA ProductA { get; }
        public AbstractProductB ProductB { get; }

        public Client(AbstractFactory factory)
        {
            ProductA = factory.CreateProductA();
            ProductB = factory.CreateProductB();
        }

        public string Run()
        {
            return ProductA.MethodOnProductB(ProductB);
        }
        
    }
}