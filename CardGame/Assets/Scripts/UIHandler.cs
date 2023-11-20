using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private DeckManager deckManager;
    [SerializeField] private Text playerdecknum;
    [SerializeField] private Text discarddecknum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerdecknum.text = deckManager.playerDeck.Count.ToString();
        discarddecknum.text = deckManager.playerDiscardDeck.Count.ToString();
    }
}
