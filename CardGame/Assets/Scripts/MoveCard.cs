using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCard : MonoBehaviour
{
    public float speed = 3f;
    public float cardOffset;
    
    
    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = Camera.main.transform.position;
        Vector3 cardOffsetPos = new Vector3(transform.position.x, cameraPos.y + cardOffset, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, cardOffsetPos, speed * Time.deltaTime);

        if (transform.position == cardOffsetPos)
        {
            GameObject card = this.gameObject;
            card.GetComponent<MoveCard>().enabled = false;
        }

    }

}
