using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class BackgroundLoop : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private float width;
        
    private void Start()
    {
        foreach (Transform child in transform)
        {
            boxCollider = child.GetComponent<BoxCollider2D>();
            if (boxCollider != null)
            {
                width = boxCollider.size.x;
            }
        }
    }

    private void Update()
    {
        if (transform.position.x <= -width)
        {
            Reposition();
        }
    }

    private void Reposition()
    {
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
