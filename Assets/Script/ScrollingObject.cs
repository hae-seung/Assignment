using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed;
    private void Update()
    {
       
        transform.Translate(Vector3.left * speed * Time.deltaTime);
       
    }

    
}
