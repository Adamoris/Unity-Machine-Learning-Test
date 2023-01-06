using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Thruster : MonoBehaviour
{
    Rigidbody rb;
    public float power = 10f;
    public float maxSpeed = 10f;
    public UI_Bar bar;
    public TextMeshProUGUI powerText;
    public KeyCode code;
    Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        powerText.text = $"Power Level: {power}";
        bar.SetMax(maxSpeed);
    }

    void FixedUpdate()
    {
        if (maxSpeed < rb.velocity.y)
        {
            return;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(new Vector3(0,1,0) * power);
        }
        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddRelativeForce(new Vector3(0,0,1) * power);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(new Vector3(-1,0,0) * power);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(new Vector3(0,0,-1) * power);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(new Vector3(1,0,0) * power);
        }

        bar.SetVal(rb.velocity.y);
    }
}
