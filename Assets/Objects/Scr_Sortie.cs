using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Sortie : MonoBehaviour
{
    public bool inTrigger;
    GameObject player;


    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetButtonDown("Down"))
            {
                Debug.Log("Enter");
            }

        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        inTrigger = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        inTrigger = false;
    }



    



}
