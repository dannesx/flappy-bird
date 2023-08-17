using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    public float deadZone;

    void Update(){
        if(transform.position.x < deadZone) Destroy(gameObject);
    }

    void FixedUpdate(){
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
