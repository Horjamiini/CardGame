using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public CardInfo[] cards;
    public GameObject cardPrefab; 
    public Transform cardSpawnPoint;
    public float horizontalSpacing = 1f;
    public float verticalSpacing = 1f;
    public float cardWidth = 100f;

    public void DrawCard()
    {
        CardInfo drawnCard = GetRandomCard();
        GameObject gameObject = Instantiate(cardPrefab, CardPosition(), Quaternion.identity);

        gameObject.transform.SetParent(transform);

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

    private Vector3 CardPosition()
    {

        int totalCards = transform.childCount;
        int row = totalCards / NumberOfColumns();
        int column = totalCards % NumberOfColumns();
        Debug.Log(totalCards);
        Debug.Log(row);
        Debug.Log(column);
        float xPos = cardSpawnPoint.position.x + column * (cardWidth + horizontalSpacing);
        float yPos = cardSpawnPoint.position.y - row * (cardWidth + verticalSpacing);

        return new Vector3(xPos, yPos, cardSpawnPoint.position.z);
    }

    private int NumberOfColumns()
    {
        float screenWidth = Screen.width;
        int numberOfColumns = Mathf.FloorToInt(screenWidth / (cardWidth + horizontalSpacing));
        return numberOfColumns;
    }

    private CardInfo GetRandomCard()
    {
        int rnd = Random.Range(0, cards.Length);
        return cards[rnd];
    }

}
