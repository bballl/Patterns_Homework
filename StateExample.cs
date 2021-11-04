namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public class StateExample
    {
        private Player _player;
        private Listener _listener;

        public StateExample()
        {
            _listener = new Listener();
            _player = new Player();
            _listener.Add(_player);
            ChangeState();
        }

        public void ChangeState()
        {
            _player.State = new StateNeutral();
            _player.State = new StateRise();
            _player.State = new StateManeuvering();
            _player.State = new StateLanding();
        }
    }
}
