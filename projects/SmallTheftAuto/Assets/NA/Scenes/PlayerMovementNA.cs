using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNA : MonoBehaviour{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;


    private void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}


