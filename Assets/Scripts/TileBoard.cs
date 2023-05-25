using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBoard : MonoBehaviour
{
    public Tile tilePrefab;
    private TileGrid grid;
    private List<Tile> tiles;
    public TileState[] tileStates;
    private void Awake()
    {
        grid=GetComponentInChildren<TileGrid>();
        tiles=new List<Tile>(16);
    }
    private void Start()
    {
        CreateTile();
        CreateTile();
    }
    private void CreateTile()
    {
        Tile tile = Instantiate(tilePrefab, grid.transform);
        tile.SetState(tileStates[0], 2);
        tile.Spawn(grid.GetRandomEmptyEmptyCell());
        tiles.Add(tile);
    }
}
