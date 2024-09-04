using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private float time = 5.0f;
    private float curTime = 0.0f;

    private void Update()
    {
        curTime += Time.deltaTime;
        if(curTime >= time)
            Destroy(gameObject);
    }
}
