using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AA3209
{
    public class Weapon : MonoBehaviour, IWeapon, IEquippable
    {
        public int Damage;
        public int Range;

        public virtual void Attack()
        {
            Debug.Log("Attacking!!");
        }

        public void Equip()
        {
            Debug.Log("Equip weapon");
        }

        public void Unequip()
        {
            Debug.Log("Unequip weapon");
        }
    }
}
