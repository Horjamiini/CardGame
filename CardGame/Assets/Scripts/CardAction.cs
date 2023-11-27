using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CardAction: MonoBehaviour
{
    private CardActionHandler lastHovered;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            CardActionHandler card = hit.collider.GetComponent<CardActionHandler>();

            if (card != null)
            {
                if (lastHovered != card)
                {
                    if (lastHovered != null)
                    {
                        lastHovered.OnHoverExit();
                    }

                    card.OnHover();
                    lastHovered = card;
                }
                if (Input.GetMouseButtonDown(0))
                {
                    card.OnClick();
                    
                }
            }
            else
            {
                if (lastHovered != null)
                {
                    lastHovered.OnHoverExit();
                    lastHovered = null;
                }
            }
        }
        else
        {
            if (lastHovered != null)
            {
                lastHovered.OnHoverExit();
                lastHovered = null;
            }
        }
    }
}
