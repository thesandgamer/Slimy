using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_BasePlayer : MonoBehaviour
{
    public float slimeNb = 20;
    public float slimeMax;

    float timer = 1;
    float cooldown = 0;

    void Start()
    {
        slimeMax = slimeNb;
    }

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

    public void GainSlime(float number)
    {


        cooldown += Time.deltaTime;

        if (cooldown >= timer)
        {
            if (slimeNb < slimeMax)
            {
                slimeNb += number;
            }
            cooldown -= timer;
        }

       

    }

    public void Dead()
    {
        Debug.Log("Dead");
    }


}
