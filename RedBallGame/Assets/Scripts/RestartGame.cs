using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public string playerTag = "Player";
    public float delay = 1.0f;
    public string nextScene = "0";

    private bool collisionDetected = false;
    //private float timer = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            //collisionDetected = true;
            //timer = delay;
            Invoke("DelayTime", delay);
        }
    }
   

    void DelayTime()
    {

        if(nextScene == "exit")
        { 
            Application.Quit();
        }
        SceneManager.LoadScene(nextScene);

    }
}
