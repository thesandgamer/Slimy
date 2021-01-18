using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Scr_PlaceSlime : MonoBehaviour
{
    [Header("   Tiles/TileMaps")]
    public Tile slimeTile;
    public Tilemap slimeTileMap;
    public Tilemap groundTileMap;

    [Header("   Controller")]
    public Scr_BasePlayer player;

    public CharacterController2D controller;

    public bool ground;
    public bool grounded;

    public float groundedSkin = 0.05f;
    public LayerMask mask;

    Vector2 playerSize;


    void Awake()
    {
        playerSize = GetComponent<BoxCollider2D>().size;
    }

    void Update()
    {

        Vector2 rayStart = (Vector2)transform.position + Vector2.down * playerSize.y * 0.5f;
        grounded = Physics2D.Raycast(rayStart, Vector2.down, groundedSkin, mask);
        Debug.DrawRay(rayStart, Vector2.down * 5, Color.yellow);

    }
    void FixedUpdate()
    {

        Vector3Int currentCell = slimeTileMap.WorldToCell(transform.position);
        currentCell.y -= 1;

        var groundTile = groundTileMap.GetTile(currentCell);

        if(groundTile != null )
        {
            ground = true;
        }
        else if (groundTile == null)
        {
            ground = false;
        }




    }

    public void PlaceSlime()
    {
        Vector3Int currentCell = slimeTileMap.WorldToCell(transform.position);
        currentCell.y -= 1;
        //Debug.Log(currentCell);

        var tile = slimeTileMap.GetTile(currentCell);

        if (tile == null && ground && grounded)
        {
            slimeTileMap.SetTile(currentCell, slimeTile);
            player.RemoveSlime(1);
            //Debug.Log("PasVide");
        }
    }


}
