using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Tuyau : MonoBehaviour
{
    private bool inTrigger;
    GameObject player;
    public Scr_BasePlayer joueur ;

    void Update()
    {
        if (inTrigger)
        {
            joueur.GainSlime(1);
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
