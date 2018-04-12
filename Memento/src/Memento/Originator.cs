using System;

namespace Memento
{
    public class Originator
    {
        public (string Id, int balance) State { get; set; }

        public Originator(string Id)
        {
            State = (Id, 0);
        }

        public Originator(){
            
        }

        public Memento CreateMemento()
        {
            return new Memento()
                .SetState(State);
        }

        public void SetMemento(Memento memento)
        {
            this.State = memento.State;
        }

    }
}
