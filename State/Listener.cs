using UnityEngine;

namespace AsteroidsState
{
    public sealed class Listener
    {
        public void Add(Player player)
        {
            player.StateInfo += PlayerStateInfo;
        }

        public void Remove(Player player)
        {
            player.StateInfo -= PlayerStateInfo;
        }

        private void PlayerStateInfo(string text)
        {
            Debug.Log(text);
        }
    }
}