using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_BasePlayer : MonoBehaviour
{
    [Header("   Slime")]
    public float slimeNb = 20;
    public float slimeMax;


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
        else if (slimeNb <= 0)
        {
            Dead();
        }


    }

    public void GainSlime(float number)
    {
        if (slimeNb < slimeMax)
        {
            slimeNb += number;
        }
    }

    public void Dead()
    {
        Debug.Log("Dead");
       //SceneManager.LoadScene("S_MainMenu");
    }


}
