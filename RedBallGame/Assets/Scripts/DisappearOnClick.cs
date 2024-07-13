using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }
}
