using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour, IMace
{
    public void Attack()
    {
        Debug.Log("Attack with Mace");
    }
    public void SwingAttack()
    {
        Debug.Log("Swing Attack");
    }

    public void Equip()
    {
        Debug.Log("Equip Mace");
    }
    public void Unequip()
    {
        Debug.Log("Unequip Mace");
    }
}
