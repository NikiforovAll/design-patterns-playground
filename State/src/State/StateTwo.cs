namespace State
{
    public class StateTwo : BaseState
    {
        public StateTwo(BaseState state)
        {
            Threshold = 3;
            Value = state.Value;
            Client = state.Client;
        }


        protected override void HandleContext()
        {
            if (base.IsNeedToChangeState())
            {
                Client.State = new StateOne(Client);
            }
        }
    }
}