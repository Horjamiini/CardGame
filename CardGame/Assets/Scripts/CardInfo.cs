using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "CardInfo", menuName = "CardInfo", order = 1)]
public class CardInfo : ScriptableObject
{
    public string CardName;
    public string CardDescription;
    public int Energy;
    public Sprite image;
}
