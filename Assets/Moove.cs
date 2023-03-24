using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moove : MonoBehaviour
{
    public float tim = 0;
    public Vector2 direction;
    public Vector2 direction2;
    public float acceleration;
    public Rigidbody2D rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(direction.normalized* acceleration);
        tim = tim + Time.deltaTime;
        if (tim == 1) 
        {
            rb.AddForce(direction2.normalized* acceleration);
        }
    }
}