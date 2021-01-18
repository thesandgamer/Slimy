using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Tuyau : MonoBehaviour
{
    private bool inTrigger;
    GameObject player;
    [Header("   Controller")]
    public Scr_BasePlayer joueur ;

    [Header("   GainSlime")]
    [Tooltip("  Combien de Slime il donne")]
    public float slimeValue = 1;
    [Tooltip("  Tout les combiens il donne du Slime")]
    public float gainSlimeTimer = 0.5f;
    float cooldown = 0;
    

    void Update()
    {
        if (inTrigger)
        {
            cooldown += Time.deltaTime;

            if (cooldown >= gainSlimeTimer)
            {
                joueur.GainSlime(slimeValue);
                cooldown -= gainSlimeTimer;
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
