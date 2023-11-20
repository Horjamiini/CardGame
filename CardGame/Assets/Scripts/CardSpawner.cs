using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public DeckManager deckManager;
    public CardManager cardmanager;
    // Start is called before the first frame update
    void Start()
    {
        SpawnCards();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnCards()
    {
        for (int i = 0; i < 2; i++)
        {
            cardmanager.DrawCard();
        }
    }

}
