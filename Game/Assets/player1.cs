using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
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

        Move();

      
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    
    private void Move()
    {
        
        float moveInput = Input.GetAxis("Horizontal");

       
        transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);
        
    }

 
    private void Jump()
    {
        
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}


