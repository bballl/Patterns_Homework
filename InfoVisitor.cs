using UnityEngine;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public class InfoVisitor : IVisitor
    {
        public virtual void Info(AsteroidGreen asteroid)
        {
            Debug.Log("Замечен AsteroidGreen");
        }

        public virtual void Info(AsteroidBlue asteroid)
        {
            Debug.Log("Замечен AsteroidBlue");
        }
    }
}
