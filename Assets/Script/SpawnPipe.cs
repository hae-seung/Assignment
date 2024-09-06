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
        time = 1.0f;
    }
    
    private void Update()
    {
        curTime += Time.deltaTime;
        if (curTime >= time && !GameManager.Instance.Dead)
        {
            GameObject pipe = Instantiate(pipePrefab);
            pipe.transform.position = new Vector3(0, Random.Range(-5.29f, 0.37f), 0);
            pipe.transform.parent = gameObject.transform;
            curTime = 0;
            time = UnityEngine.Random.Range(1.5f, 2.5f);
        }
    }
}
