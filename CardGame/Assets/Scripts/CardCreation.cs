using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class CardCreation : MonoBehaviour
{
    GameObject card;

    
    // Start is called before the first frame update
    void Start()
    {
        card = GetComponent<GameObject>();
       Debug.Log(card.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
