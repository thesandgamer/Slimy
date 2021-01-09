using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_JumpCollision : MonoBehaviour
{
    [Range(1, 10)]
    public float jumpVelocity;

    bool jumpRequest;
    List<Collider2D> groundTouched = new List<Collider2D>();

    void Update()
    {
        if (Input.GetButtonDown("Jump") && groundTouched.Count != 0)
        {
            jumpRequest = true;
        }
    }

    void FixedUpdate()
    {
        if (jumpRequest)
        {
            // GetComponent<Rigidbody2D>().velocity += Vector2.up * jumpVelocity;
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);

            jumpRequest = false;
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        ContactPoint2D[] points = new ContactPoint2D[2];
        c.GetContacts(points);
        for (int i = 0; i< points.Length;i++)
        {
            if (points[i].normal == Vector2.up && !groundTouched.Contains(c.collider))
            {
                groundTouched.Add(c.collider);
                return;
            }
            
        }

    }

    private void OnCollisionExit2D(Collision2D c)
    {
        if (groundTouched.Contains(c.collider))
        {
            groundTouched.Remove(c.collider);
        }
    }
}
