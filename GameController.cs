using UnityEngine;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public sealed class GameController : MonoBehaviour
    {
        private void Start()
        {
            var state = new StateExample();
            var visitor = new VisitorExample();

            var bridge = new ShipForBridgePattern();
            bridge.Attack(new RocketAttack());
            bridge.Attack(new ShootingAttack());

            var proxy = new ProxyExample();
        }
    }
}
