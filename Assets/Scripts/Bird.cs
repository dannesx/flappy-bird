using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D col;
    GameManager Manager;
    public float flapForce;
    bool isAlive = true;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        Manager = FindObjectOfType<GameManager>();
    }

    void Update(){
        if(Input.GetKeyDown("space") && isAlive) rb.velocity = Vector2.up * flapForce;
    }

    void OnCollisionEnter2D(){
        isAlive = false;
        col.enabled = false;
        rb.velocity = Vector2.down * flapForce * 4f;
        Manager.GameOver();
    }

    void OnTriggerEnter2D(){
        Manager.AddScore();
    }
}