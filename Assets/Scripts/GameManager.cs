using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    public Scr_BasePlayer player;
    public Text nbSlimeTxt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerSlimeNb = player.GetSlimeNb();
        nbSlimeTxt.text = playerSlimeNb.ToString();
    }
}
