using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door1 : MonoBehaviour
{

    Vector3 originalPos;
    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
        originalPos = new Vector3((float)-6.9088, (float)-3.0436, (float)0);
    }

    private void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player2"))
        {
            Destroy(gameObject);
            GetComponent<Collider2D>().isTrigger = true;
        }
        if (c2d.CompareTag("Player"))
        {
            c2d.transform.position = originalPos;


        }
 
    }

 
}
