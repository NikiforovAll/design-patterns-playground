namespace ChainOfResponsibility
{
    public class Director : Approver
    {
        public Director(string id) :base (id)
        {
        }
        public override (bool, ProcessingLevel) ProcessRequest(Purchase purchase) => purchase.Amount < 10 ? (true, ProcessingLevel.Accepted) : successor.ProcessRequest(purchase);
    }
}