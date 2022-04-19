using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeSpawner2D : MonoBehaviour
{
   
    public Cell CellPrefab;
    public Vector2 CellSize = new Vector3(1,1);
    public Maze maze;
    static public int count;
    private GameObject[] objects;
    
    private void Start()
    {
        MazeGenerator generator = new MazeGenerator();
        maze = generator.GenerateMaze();

        for (int x = 0; x < maze.cells.GetLength(0); x++)
        {
            for (int y = 0; y < maze.cells.GetLength(1); y++)
            {
                Cell c = Instantiate(CellPrefab, new Vector2(x * CellSize.x, y * CellSize.y), Quaternion.identity);
               
                c.WallLeft.SetActive(maze.cells[x, y].WallLeft);
                c.WallBottom.SetActive(maze.cells[x, y].WallBottom);
                c.Exit.SetActive(maze.cells[x, y].Exit);
            }
        }//Спавн Стенок и выхода.
        
        
    }
    


}
