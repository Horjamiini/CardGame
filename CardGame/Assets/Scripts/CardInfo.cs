using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CardInfo", menuName = "Card")]
public class CardInfo : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public int cardEnergy;
    public int cardDamage;
    public int cardSelfDamage;
    public string cardType;
    public Sprite cardArt;
    public CardInfo cardData;
}
