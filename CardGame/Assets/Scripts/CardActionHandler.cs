using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardActionHandler : MonoBehaviour
{
    private Renderer r;
    private Material cardMaterial;
    private Color cardStartColor;
    private bool isClicked = false;
    private DeckManager deckmanager;
    private Player player;
    private Enemy enemy;
    void Awake()
    {
        r = GetComponent<Renderer>();
        cardMaterial = r.material;
        cardStartColor = cardMaterial.color;
        deckmanager = FindObjectOfType<DeckManager>();
        player = FindObjectOfType<Player>();
        enemy = FindObjectOfType<Enemy>();
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
        DamageEnemy(card);
        deckmanager.playerDiscardDeck.Add(cardData);
        Destroy(gameObject);
    }

    private void DamageEnemy(CardDataHandler card)
    {
        enemy.TakeDamage(card.cardDamage);

        if (card.cardSelfDamage > 0)
        {
            player.TakeDamage(card.cardSelfDamage);
        }
    }
}
