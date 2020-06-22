using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;
    private float rbVelocity;
    private int dirx, dirz;
    private Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        speed = 0.2f;
        rbVelocity = 9f;
        dirx = 0;
        dirz = 0;
        initialPosition = new Vector3(1, 2.04f, -9);
    }

    public void Reset()
    {
        dirx = 0;
        dirz = 0;
        rb.velocity = new Vector3(0, 0, 0);
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey("d"))
        {
            dirx = 1;
            dirz = 0;
            rb.AddForce(new Vector3(speed, 0, 0), ForceMode.Impulse);
        }else if(Input.GetKey("a"))
        {
            dirx = -1;
            dirz = 0;
            rb.AddForce(new Vector3(-speed, 0, 0), ForceMode.Impulse);
        } else if(Input.GetKey("w"))
        {
            dirz = 1;
            dirx = 0;
            rb.AddForce(new Vector3(0, 0, speed), ForceMode.Impulse);
        }else if (Input.GetKey("s")){
            dirz = -1;
            dirx = 0;
            rb.AddForce(new Vector3(0, 0, -speed), ForceMode.Impulse);
        }

        rb.velocity = new Vector3(rbVelocity*dirx, rb.velocity.y, rbVelocity*dirz);

    }
}
