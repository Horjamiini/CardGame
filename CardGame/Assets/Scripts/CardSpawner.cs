using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public int[] cards;
    public CardManager manager;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cards.Length; i++)
        {
            manager.DrawCard();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
