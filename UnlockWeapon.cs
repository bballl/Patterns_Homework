namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public sealed class UnlockWeapon
    {
        public bool IsUnlock { get; set; }

        public UnlockWeapon(bool isUnlock)
        {
            IsUnlock = isUnlock;
        }
    }
}
