namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    class ProxyExample
    {
        public ProxyExample()
        {
            var unlockWeapon = new UnlockWeapon(false);
            var ship = new ShipForProxyPattern();
            var weaponProxy = new WeaponProxy(ship, unlockWeapon);
            weaponProxy.Fire();
            unlockWeapon.IsUnlock = true;
            weaponProxy.Fire();
        }
    }
}
