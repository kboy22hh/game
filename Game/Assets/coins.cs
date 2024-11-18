using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coins : MonoBehaviour
{
    // Start is called before the first frame update
    public static int totalCoins = 0;

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player"))
        {
            totalCoins++;
            Destroy(gameObject);
        }


        if (totalCoins == 3)
        {
            SceneManager.LoadScene("level 2");
        }




        
    }
}
