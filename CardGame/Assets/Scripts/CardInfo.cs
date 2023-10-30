using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="CardInfo", menuName = "Card")]
public class CardInfo : ScriptableObject
{
    public string cardName;
    public string cardDescription;
    public int cardEnergy;
    public Sprite cardArt;
}
