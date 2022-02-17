using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeControls : MonoBehaviour
{
    public float dragSpeed = 1f;
    public float DragSmoothness = 5f;
    public float tiltSmoothness = 5f;
    public float leftRightMaxConstraint = 30f;
    public float tiltAngle= 45; 
    public float movementAngle= 20; 
    public float xMinMax = 5f;


    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xAxis = Input.GetAxis("Horizontal");
        Quaternion targetRotation = Quaternion.Euler(xAxis * tiltAngle, xAxis * movementAngle, 0);
        Vector3 targetPosition = transform.position + Vector3.forward * xAxis * dragSpeed;
        transform.position = Vector3.Lerp(transform.position, targetPosition, DragSmoothness * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -xMinMax, xMinMax));
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, tiltSmoothness * Time.deltaTime);
    }
}
