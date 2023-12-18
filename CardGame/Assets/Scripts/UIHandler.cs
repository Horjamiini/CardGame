using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    [SerializeField] private CardManager cardManager;
    [SerializeField] private DeckManager deckManager;
    [SerializeField] private Text playerDeckNum;
    [SerializeField] private Text discardDeckNum;
    [SerializeField] private Button drawButton;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        playerDeckNum.text = deckManager.playerDeck.Count.ToString();
        discardDeckNum.text = deckManager.playerDiscardDeck.Count.ToString();


    }

}
