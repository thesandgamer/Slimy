using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Jump : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;
    public float groundedSkin = 0.05f;

    public Scr_PlaceSlime placeSlime;
    public CharacterController2D controller;

    bool jumpRequest;

    public bool auSol;

    Vector2 playerSize;

    void Awake()
    {
        playerSize = GetComponent<BoxCollider2D>().size;
    }

    void Update()
    {
        auSol = controller.GetGrounded();

        if (Input.GetButtonDown("Jump") && auSol)
        {
            jumpRequest = true;
        }

        if (auSol)
        {
            placeSlime.PlaceSlime();
        }



    }

    void FixedUpdate()
    {
        //Saut
        if (jumpRequest)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);

            jumpRequest = false;
        }

    }
}

