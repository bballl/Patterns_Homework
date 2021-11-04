namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public interface IAsteroid
    {
        void Accept(IVisitor visitor);
    }
}
