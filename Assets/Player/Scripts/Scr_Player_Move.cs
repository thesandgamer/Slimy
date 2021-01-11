using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player_Move : MonoBehaviour
{
    [Range(1, 50)]
    public float walkSpeed = 40;

    public CharacterController2D controller;

    float horizontalMove = 0f;

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false,false);
    }

}
