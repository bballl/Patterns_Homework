using UnityEngine;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    class RocketAttack : IAttackType
    {
        public void Attack()
        {
            Debug.Log("Проведена ракетная атака");
        }
    }
}
