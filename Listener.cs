using UnityEngine;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
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