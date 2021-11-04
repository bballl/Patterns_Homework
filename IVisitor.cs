namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public interface IVisitor
    {
        void Info(AsteroidGreen asteroid);
        void Info(AsteroidBlue asteroid);
    }
}
