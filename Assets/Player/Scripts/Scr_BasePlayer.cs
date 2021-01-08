using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BasePlayer : MonoBehaviour
{
    [Range(1, 10)]
    public float walkSpeed = 5;

    void Update()
    {
        //Déplacement
        float value = Input.GetAxis("Horizontal");

        Debug.Log(value);
    }

}
