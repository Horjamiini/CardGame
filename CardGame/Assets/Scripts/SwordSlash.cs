using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SwordSlash", menuName = "SwordSlash", order = 1)]
public class SwordSlash : ScriptableObject
{
    public string prefabName = "SwordSlash";
    public string m_CardName = "Sword Slash";
    public string m_DardDescription = "Deal 4 Damage";
    public int m_AtkDmg = 4;
    public int m_Energy = 2;
}
