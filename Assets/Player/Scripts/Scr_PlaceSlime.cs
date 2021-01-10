using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Scr_PlaceSlime : MonoBehaviour
{
    public Tile slimeTile;
    public Tilemap slimeTileMap;
    public Tilemap groundTileMap;

    public Scr_BasePlayer player;

    public bool haveGround;

    public float groundedSkin = 0.05f;
    public LayerMask mask;

    Vector2 playerSize;


    void Awake()
    {
        playerSize = GetComponent<BoxCollider2D>().size;
    }

    void FixedUpdate()
    {
        /*
        Vector2 rayStart = (Vector2)transform.position + Vector2.down * playerSize.y * 0.5f;
        haveGround = Physics2D.Raycast(rayStart, Vector2.down, groundedSkin, mask);
        Debug.Log(haveGround);
        */

        Vector3Int currentCell = slimeTileMap.WorldToCell(transform.position);
        currentCell.y -= 1;

        var groundTile = groundTileMap.GetTile(currentCell);

        if(groundTile != null)
        {
            PlaceSlime();
        }

    }

    public void PlaceSlime()
    {
        Vector3Int currentCell = slimeTileMap.WorldToCell(transform.position);
        currentCell.y -= 1;
        //Debug.Log(currentCell);

        var tile = slimeTileMap.GetTile(currentCell);

        if (tile == null)
        {
            slimeTileMap.SetTile(currentCell, slimeTile);
            player.RemoveSlime(1);
            //Debug.Log("PasVide");
        }
    }


}
