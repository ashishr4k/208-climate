using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 2.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.velocity = -transform.right * speed;
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(0, 0, 1) * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector3(0, 0, -1) * speed;
        }
    }
}
