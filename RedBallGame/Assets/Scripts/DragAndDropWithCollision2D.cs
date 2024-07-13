using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropWithCollision2D : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            rb = gameObject.AddComponent<Rigidbody2D>();
        }
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
        rb.isKinematic = true; // Set to kinematic to control the object manually
    }

    void OnMouseUp()
    {
        isDragging = false;
        rb.isKinematic = false; // Set back to dynamic to interact with physics
    }
}
