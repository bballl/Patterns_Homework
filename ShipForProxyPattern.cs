using UnityEngine;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    class ShipForProxyPattern : IWeapon
    {
        public void Fire()
        {
            Debug.Log("ShipForProxyPattern атакует");
        }
    }
}
