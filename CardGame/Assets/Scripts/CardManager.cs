using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{

    [SerializeField] private GameObject cardPrefab;
    [SerializeField] private DeckManager deckManager;
    [SerializeField] private Transform cardSpawnPoint;
    [SerializeField] private float horizontalSpacing = 1f;
    [SerializeField] private float verticalSpacing = 1f;
    [SerializeField] private float cardWidth = 100f;
    
    
    public void DrawCard()
    {
    
        CardInfo drawnCard = deckManager.GetRandomCard();

        GameObject gameObject = Instantiate(cardPrefab, CardPosition(), Quaternion.identity);

        gameObject.transform.SetParent(transform);

        CardDataHandler cardHandler = gameObject.GetComponent<CardDataHandler>();
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
}
