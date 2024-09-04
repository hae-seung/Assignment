using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    private float time;
    private float curTime;

    private void Start()
    {
        time = UnityEngine.Random.Range(1.5f,2.5f);
    }
    
    private void Update()
    {
        curTime += Time.deltaTime;
        if (curTime >= time)
        {
            GameObject pipe = Instantiate(pipePrefab);
            pipe.transform.position = new Vector3(0, Random.Range(-4.17f, 2.62f), 0);
            pipe.transform.parent = gameObject.transform;
            curTime = 0;
            time = UnityEngine.Random.Range(1.5f, 2.5f);
        }
    }
}
