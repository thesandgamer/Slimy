using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BasePlayer : MonoBehaviour
{
    public float slimeNb = 20;


    public float GetSlimeNb()
    {
        return slimeNb;
    }

    public void RemoveSlime(float number)
    {
        if (slimeNb >0)
        {
            slimeNb -= number;
        }
        else 
        {
            Dead();
        }
        

    }

    public void Dead()
    {
        Debug.Log("Dead");
    }


}
