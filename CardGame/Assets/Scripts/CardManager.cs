using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public CardInfo[] cards;
    public GameObject cardPrefab;

    public Transform cardSpawnPoint;

    public void DrawCard()
    {
        CardInfo drawnCard = GetRandomCard();
        GameObject gameObject = Instantiate(cardPrefab, cardSpawnPoint.position,Quaternion.identity);

        CardHandler cardHandler = gameObject.GetComponent<CardHandler>();

        if (cardHandler != null)
        {
            cardHandler.UpdateCardUI(drawnCard);
        }
        else
        {
            Debug.Log("Component not found!");
        }
    }

    private CardInfo GetRandomCard()
    {
        int rnd = Random.Range(0, cards.Length);
        return cards[rnd];
    }
}
