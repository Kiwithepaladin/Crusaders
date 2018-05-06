﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    Animator anim;
    private bool isMoving;
    private Rigidbody2D rigd2d;
    private Vector2 lastDirection;
    void Start()
    {
        anim = GetComponent<Animator>();
        rigd2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        CheckInput();
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            anim.Play("Maya_AttackDown");
            anim.StopPlayback();
        }

    }


    void CheckInput()
    {
        isMoving = false;

        var h = Input.GetAxisRaw("Horizontal");
        var v = Input.GetAxisRaw("Vertical");

        if(h < 0 || h > 0 || v < 0 || v > 0)
        {
            isMoving = true;
            if (!GetComponent<BoxCollider2D>().IsTouchingLayers(Physics2D.AllLayers))
                lastDirection = rigd2d.velocity;
            else
                lastDirection = rigd2d.velocity;
        }

        var moveVector = new Vector2(h, v);
        Movment(moveVector * moveSpeed);
    }

    void Movment(Vector2 moveVector)
    {
        rigd2d.velocity = Vector2.zero;
        rigd2d.AddForce(moveVector, ForceMode2D.Impulse);

        SendAnimInfo();
    }

    void SendAnimInfo()
    {
        anim.SetFloat("XSpeed", rigd2d.velocity.x);
        anim.SetFloat("YSpeed", rigd2d.velocity.y);

        anim.SetFloat("LastX", lastDirection.x);
        anim.SetFloat("LastY", lastDirection.y);

        anim.SetBool("IsMoving", isMoving);
    }

    
}