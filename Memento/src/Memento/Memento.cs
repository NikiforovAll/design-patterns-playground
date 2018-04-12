namespace Memento
{
    public class Memento
    {
        public (string Id, int balance) State { get; private set;}

        //probably better to use read-only state

        internal Memento(){
            
        }
        public Memento SetState((string Id, int balance) state)
        {
            State = state;
            return this;
        }
    }
}