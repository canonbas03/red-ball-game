using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRollSound : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.velocity.magnitude;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!audioSource.isPlaying && speed >= 0.1f && collision.gameObject.tag == "Ground")
        {
            audioSource.Play();
        }
        else if (audioSource.isPlaying && speed < 0.1f && collision.gameObject.tag == "Ground")
        {
            audioSource.Pause();
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(audioSource.isPlaying && collision.gameObject.tag == "Ground")
        {
            audioSource.Pause();
        }
    }
}
