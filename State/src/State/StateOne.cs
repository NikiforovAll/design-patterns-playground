namespace State
{
    public class StateOne : BaseState
    {

        public StateOne(StateClient client)
        {
            Client = client;
        }
        protected override void HandleContext()
        {
            if (base.IsNeedToChangeState())
            {
                Client.State = new StateTwo(this);
            }
        }
    }
}