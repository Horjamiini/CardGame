using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardHandler : MonoBehaviour
{
    public Image cardImage;
    public Text cardNameText;
    public Text cardDescText;
    public Text cardEnergyText;

    public void UpdateCardUI(CardInfo cardInfo)
    {
        cardImage.sprite = cardInfo.cardArt;
        cardNameText.text = cardInfo.cardName;
        cardDescText.text = cardInfo.cardDescription;
        cardEnergyText.text = cardInfo.cardEnergy.ToString();
    }
}
