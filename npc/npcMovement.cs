using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcMovement : MonoBehaviour
{

    private float speed;

    void Start(){
        speed = Random.Range(10.0f, 18.0f);
    }

    void FixedUpdate()
    {

        transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
    }
}
