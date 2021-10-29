using UnityEngine;
using System;

namespace AsteroidsState
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
