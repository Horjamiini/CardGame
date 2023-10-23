using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "AttackCard", menuName = "AttackCard", order = 1)]
public class AttackCard : ScriptableObject
{
    public string prefabName = "Card";
    public string m_CardName = "Sword Slash";
    public string m_DardDescription = "Deal 4 gamage";
    public int m_AtkDmg = 4;
    public int m_Energy = 2;
}
