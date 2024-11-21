using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

   
    private Rigidbody2D rb;

    
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {

        Walk();

      
        if (Input.GetButtonDown("Jump2"))
        {
            Leap();
        }
    }

    
    private void Walk()
    {
        
        float moveInput = Input.GetAxis("H2");

       
        transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);
        
    }

 
    private void Leap()
    {
        
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}


