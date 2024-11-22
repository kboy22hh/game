using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour
{

    public string startScene = "Start";

    public void Startgame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Restartgame()
    {
        SceneManager.LoadScene("Start");
    }

}
