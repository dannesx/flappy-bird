using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float extension;
    public float speed;

    void FixedUpdate(){
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
