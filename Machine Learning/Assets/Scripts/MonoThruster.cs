using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoThruster : MonoBehaviour
{
    Rigidbody rb;
    public float power = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // rb.AddRelativeForce(new Vector3(0,1,0) * power);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(new Vector3(0,0,1) * power);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // rb.AddRelativeForce(new Vector3(-1,0,0) * power);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // rb.AddRelativeForce(new Vector3(0,0,-1) * power);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // rb.AddRelativeForce(new Vector3(1,0,0) * power);
        }
    }
}