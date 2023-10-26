using AA3209;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Dagger : Weapon, IThrowable
{
    public int ThrowingRange { get; set; }

    public override void Attack()
    {
        Debug.Log("Attack in melee range");
    }

    public void Throw(int throwingspeed)
    {
        Debug.Log($"Throwing the dagger at speed {throwingspeed}");
    }
}
