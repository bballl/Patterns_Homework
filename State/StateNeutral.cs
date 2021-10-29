using UnityEngine;

namespace AsteroidsState
{
    public sealed class StateNeutral : IState
    {
        public string Info { get; } = "Ожидание";
    }
}
