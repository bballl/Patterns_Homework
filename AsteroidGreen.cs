namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public class AsteroidGreen : IAsteroid
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Info(this);
        }
    }
}
