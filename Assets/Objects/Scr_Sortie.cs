using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_Sortie : MonoBehaviour
{
    private bool inTrigger;
    GameObject player;

    [Tooltip("Scene o� aller")]
    public string level;

    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetButtonDown("Down"))
            {
                GoToLevel();
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

    public void GoToLevel()
    {
        SceneManager.LoadScene(level);
    }






}
