using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CardInfo", menuName = "CardInfo", order = 1)]
public class CardInfo : ScriptableObject
{
    public string prefabName = "Card";
    public string m_CardName;
    public string m_DardDescription;
    public int m_AtkDmg;
    public int m_Energy;
}
