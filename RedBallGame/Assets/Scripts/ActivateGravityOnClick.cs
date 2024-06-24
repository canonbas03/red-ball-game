using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGravityOnClick : MonoBehaviour
{
    public float gravityScale = 1f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        if (rb != null)
        {
            rb.gravityScale = gravityScale;
        }
    }
}
