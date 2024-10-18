using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{

    Rigidbody2D rb;

    float moveforce = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * moveforce * Input.GetAxis("Horizontal"), ForceMode2D.Force);
    }
}
