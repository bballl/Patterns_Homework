namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    class ShipForBridgePattern
    {
        public void Attack(IAttackType attackType)
        {
            attackType.Attack();
        }
    }
}
