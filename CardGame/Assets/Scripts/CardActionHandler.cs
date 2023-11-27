using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardActionHandler : MonoBehaviour
{
    Renderer r;
    Material cardMaterial;
    Color cardStartColor;
    private DeckManager deckmanager;
    private bool isClicked = false;
    void Awake()
    {
        r = GetComponent<Renderer>();
        cardMaterial = r.material;
        cardStartColor = cardMaterial.color;
        deckmanager = FindObjectOfType<DeckManager>();
    }
    public void OnHover()
    {
        if (!isClicked)
        {
            cardMaterial.color = Color.yellow;
            transform.position += new Vector3(0, 3, 0);
        }
    }

    public void OnHoverExit()
    {
        if (!isClicked)
        {
            GetComponent<Renderer>().material.color = cardStartColor;
            transform.position += new Vector3(0, -3, 0);
        }
    }
    public void OnClick()
    {
        isClicked = true;
        transform.position += new Vector3(0, 5, 0);
        Invoke("PlayCard", 1);
    }

    private void PlayCard()
    {
        CardDataHandler card = gameObject.GetComponent<CardDataHandler>();
        CardInfo cardData = card.cardData;
        deckmanager.playerDiscardDeck.Add(cardData);
        Destroy(gameObject);
    }
}
