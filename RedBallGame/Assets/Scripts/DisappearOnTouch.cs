using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnTouch : MonoBehaviour
{
    public string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            gameObject.SetActive(false);
        }
    }
}
