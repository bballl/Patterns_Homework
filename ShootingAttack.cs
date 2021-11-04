using UnityEngine;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    class ShootingAttack : IAttackType
    {
        public void Attack()
        {
            Debug.Log("Проведена стрелковая атака");
        }
    }
}
