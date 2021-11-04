﻿using UnityEngine;

namespace Patterns_State_Visitor_Observer_Bridge_Proxy
{
    public sealed class WeaponProxy : IWeapon
    {
        private readonly IWeapon _weapon;
        private readonly UnlockWeapon _unlockWeapon;

        public WeaponProxy(IWeapon weapon, UnlockWeapon unlockWeapon)
        {
            _weapon = weapon;
            _unlockWeapon = unlockWeapon;
        }

        public void Fire()
        {
            if (_unlockWeapon.IsUnlock)
            {
                _weapon.Fire();
            }
            else
            {
                Debug.Log("Weapon is lock");
            }
        }
    }
}
