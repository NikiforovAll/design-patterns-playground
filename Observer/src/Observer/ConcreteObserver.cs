namespace Observer
{
    public class ConcreteObserver: Observer
    {
        public string State { get; private set; }

        public override void Update(Subject state)
        {
            State = (state as ConcreteSubject).SubjectState;
        }
    }
}