using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_JumpBox : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;
    public float groundedSkin = 0.05f;
    public LayerMask mask;

    public Scr_PlaceSlime placeSlime;

    bool jumpRequest;
    public bool grounded;

    Vector2 playerSize;
    Vector2 boxSize;

    void Awake()
    {
        playerSize = GetComponent<BoxCollider2D>().size;
        boxSize = new Vector2(playerSize.x, groundedSkin);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded)
        {
            jumpRequest = true;
        }
    }

    void FixedUpdate()
    {
        //Saut
        if (jumpRequest)
        {
            // GetComponent<Rigidbody2D>().velocity += Vector2.up * jumpVelocity;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);

            grounded = false;
            jumpRequest = false;
        }
        else
        {
            Vector2 boxCenter = (Vector2)transform.position + Vector2.down * (playerSize.y + boxSize.y) * 0.5f; 
            grounded = (Physics2D.OverlapBox(boxCenter, boxSize, 0f,mask) != null);
        }

        if (grounded)
        {
            placeSlime.PlaceSlime();
        }

    }
}
