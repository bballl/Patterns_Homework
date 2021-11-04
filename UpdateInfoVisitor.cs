using UnityEngine;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public class UpdateInfoVisitor : InfoVisitor
    {
        public override void Info(AsteroidGreen asteroid)
        {
            if (asteroid is AsteroidGreenBlue)
            {
                Debug.Log("Замечен AsteroidGreenBlue.");
            }
            else base.Info(asteroid);
        }
    }
}