using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public string playerTag = "Player";
    public float delay = 2.0f;
    public string nextScene;

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

        SceneManager.LoadScene(nextScene);

    }
}
