using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop2DWithPhysics : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private float initialGravityScale;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }
        initialGravityScale = rb.gravityScale;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f; // Ensure z position is set to 0 for 2D
            rb.MovePosition(mousePosition + offset);
        }
    }

    void OnMouseDown()
    {
        isDragging = true;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        offset = transform.position - mousePosition;
        rb.gravityScale = 0; // Disable gravity while dragging
        rb.velocity = Vector2.zero; // Stop any existing movement
    }

    void OnMouseUp()
    {
        isDragging = false;
        rb.gravityScale = initialGravityScale; // Restore gravity when released
    }
}
