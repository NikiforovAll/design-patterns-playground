using System;

namespace ChainOfResponsibility
{
    public class President : Approver
    {
        public President(string id) :base (id)
        {
        }
        public override (bool, ProcessingLevel) ProcessRequest(Purchase purchase) => purchase.Amount < 20 ? (true, ProcessingLevel.EscalationLevelTwo) : (false, ProcessingLevel.Rejected);
    }
}