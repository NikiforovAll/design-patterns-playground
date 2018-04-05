using System.Threading;

namespace State
{
    public abstract class BaseState
    {
        public int Value { get; protected set; }
        public StateClient Client { get; set; }
        protected int Threshold { get; set; } = 1;

        public virtual bool IsNeedToChangeState()
        {
            return Value >= Threshold;
        }

        public virtual void Increment(){
            Value++;
            HandleContext();
        }
        protected abstract void HandleContext();

        public override string ToString(){
            return $"State={this.GetType().Name};Value={this.Value}";
        }
    }
}