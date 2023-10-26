using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    void Attack();
}


public interface IThrowable
{
    int ThrowingRange { get; set; }
    void Throw(int ThrowingSpeed);
}

public interface IEquippable
{
    void Equip();

    void Unequip();

}
public interface IMace : IWeapon, IEquippable
{
    void SwingAttack();
}