using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDataHandler : MonoBehaviour
{
    public Text cardNameText;
    public Text cardDescText;
    public Text cardEnergyText;
    public int cardDamage;
    public int cardSelfDamage;
    public string cardTypeText;
    public Image cardImage;
    public CardInfo cardData;
    public void UpdateCardUI(CardInfo cardInfo)
    {
        
        cardNameText.text = cardInfo.cardName;
        cardDescText.text = cardInfo.cardDescription;
        cardEnergyText.text = cardInfo.cardEnergy.ToString();
        cardDamage = cardInfo.cardDamage;
        cardSelfDamage = cardInfo.cardSelfDamage;
        cardTypeText = cardInfo.cardType;
        cardImage.sprite = cardInfo.cardArt;
        cardData = cardInfo.cardData;

    }

}
