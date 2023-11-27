using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckManager : MonoBehaviour
{
    public List<CardInfo> playerDeck = new List<CardInfo>();
    public List<CardInfo> playerDiscardDeck = new List<CardInfo>();

    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public CardInfo GetRandomCard()
    {
    int rnd = Random.Range(0, playerDeck.Count);
    CardInfo drawnCard = playerDeck[rnd]; ;
    playerDeck.RemoveAt(rnd);
    return drawnCard;
    }

    public void ShuffleDeck()
    {
        foreach(CardInfo card in playerDiscardDeck)
        {
            playerDeck.Add(card);
        }
        playerDiscardDeck.Clear();
    }
}
