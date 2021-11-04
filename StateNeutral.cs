namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public sealed class StateNeutral : IState
    {
        public string Info { get; } = "Ожидание";
    }
}
