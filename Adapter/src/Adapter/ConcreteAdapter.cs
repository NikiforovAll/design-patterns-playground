namespace Adapter
{
    public class ConcreteAdapter : IAdapter
    {
        private Adaptee _adaptee;

        public ConcreteAdapter()
        {
            this._adaptee = new Adaptee();
        }
        public string Request()
        {
            return _adaptee.ExternalRequest("default");
        }
    }
}