using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float timeBeforeDestroying;
    float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time >= startTime + timeBeforeDestroying)
        {
            Destroy(gameObject);
        }
    }
}
