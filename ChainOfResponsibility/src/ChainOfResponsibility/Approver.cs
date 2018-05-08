using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Approver
    {
        public string Id { get; }
        protected Approver successor;
        protected Approver(string id)
        {
            Id = id;
        }
        protected Approver() : this("") { }

        public void SetSuccessor(Approver approver)
        {
            this.successor = approver;
        }

        public Approver GetSuccessor() => this.successor;
        public abstract (bool, ProcessingLevel) ProcessRequest(Purchase purchase);
    }
}
