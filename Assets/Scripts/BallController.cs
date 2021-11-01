﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    Vector2 direction;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        
        direction = Vector2.one.normalized;
    }

    private void FixedUpdate() {
        rigidBody2D.velocity = direction * speed;
    }
}
