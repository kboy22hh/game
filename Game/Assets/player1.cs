using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{

    Rigidbody2D rb;
    public float movementspeed;
    public float height;
    private KeyCode lastHitKey;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, height);
        }

        if(Input.GetKeyDown (KeyCode.LeftArrow))
        {
            if(lastHitKey == KeyCode.LeftArrow) {

        }else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2 ((movementspeed - movementspeed * 2), 0);
                lastHitKey = KeyCode.LeftArrow;
            }
    }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (lastHitKey == KeyCode.RightArrow)
            {

            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2((movementspeed - movementspeed * 2), 0);
                lastHitKey = KeyCode.RightArrow;
            }
        }
    }

}
