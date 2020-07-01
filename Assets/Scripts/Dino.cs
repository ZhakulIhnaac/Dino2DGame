﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    private PolygonCollider2D col;
    public bool gameIsOn;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<PolygonCollider2D>();
        gameIsOn = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (gameIsOn)
        {
            if (rb.velocity.y != 0)
            {
                anim.SetBool("isJumping", false);
                anim.SetBool("isRunning", true);
            }
            else
            {
                anim.SetBool("isRunning", false);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity += 10f * Vector2.up;
                anim.SetBool("isJumping", true);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddTorque(10f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "Cactus(Clone)")
        {
            gameIsOn = false;
            anim.SetBool("isDead", true);
            Destroy(rb);
            Destroy(col);

        }
    }

}
