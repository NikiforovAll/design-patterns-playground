using System;

namespace ChainOfResponsibility
{
    public class VicePresident : Approver
    {
        public VicePresident(string id) :base (id)
        {
        }
        public override (bool, ProcessingLevel) ProcessRequest(Purchase purchase) => purchase.Amount < 15 ? (true, ProcessingLevel.EscalationLevelOne) : successor.ProcessRequest(purchase);
    }
}