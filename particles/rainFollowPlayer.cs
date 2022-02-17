using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainFollowPlayer : MonoBehaviour
{
    public Transform target;
    public float smoothness = 5.0f;

    private Vector3 offset;
    void Start()
    {
        offset = calculateInitialOffset();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, target.position + offset, smoothness * Time.deltaTime);
    }
    Vector3 calculateInitialOffset()
    {
        return transform.position - target.position;
    }
}
