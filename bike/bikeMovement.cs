using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeMovement : MonoBehaviour
{
    // Player Movement settings
    public float maxSpeed = 20f;
    public float acceleration = 10f;
    public float speed;

    private Rigidbody bikeRB;
    public bool isMoving = true;
    void Start()
    {
        bikeRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMoving)
        { // 
            if (speed < maxSpeed)
            {
                speed += acceleration * Time.deltaTime;
            }
        }
        else
        {
            if (speed > 0)
            {
                speed = Mathf.Max(speed - acceleration * Time.deltaTime, 0);
            }
        }
        bikeRB.velocity = Vector3.left * speed;
    }
}
