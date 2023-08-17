using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D col;
    public float flapForce;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    void Update(){
        if(Input.GetKeyDown("space")) rb.velocity = Vector2.up * flapForce;
    }
}