using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door1 : MonoBehaviour
{
    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player2"))
        {
            Destroy(gameObject);
        }
        
    }

 
}
