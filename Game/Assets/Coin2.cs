using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coin2 : MonoBehaviour
{
    // Start is called before the first frame update
    public static int totalCoins = 0;

    void Awoke()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D c2d)
    {
        if (c2d.CompareTag("Player2"))
        {
            totalCoins++;
            Destroy(gameObject);
        }


        if (totalCoins == 4)
        {
            SceneManager.LoadScene("level 2");
        }





    }
}
