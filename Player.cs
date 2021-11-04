using System;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public sealed class Player
    {
        public event Action<string> StateInfo = delegate (string text) { };
        private IState _state;

        public IState State
        {
            set
            {
                _state = value;
                StateInfo(_state.Info);
            }
        }
    }
}
