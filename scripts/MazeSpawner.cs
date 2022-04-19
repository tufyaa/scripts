using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MazeSpawner : MonoBehaviour
{
    public Cell CellPrefab;
    public Vector3 CellSize = new Vector3(1,1,0);
    public GameObject Floor;
    public Maze maze;
    public GameObject Coin;
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
                Cell c = Instantiate(CellPrefab, new Vector3(x * CellSize.x, y * CellSize.y, y * CellSize.z), Quaternion.identity);
               
                c.WallLeft.SetActive(maze.cells[x, y].WallLeft);
                c.WallBottom.SetActive(maze.cells[x, y].WallBottom);
                c.Exit.SetActive(maze.cells[x, y].Exit);
            }
        }//Спавн Стенок и выхода.
        for (int x = 1; x < maze.cells.GetLength(0); x++)
        {
            for (int y = 1; y < maze.cells.GetLength(1); y++)
            {
                Instantiate( Floor, new Vector3( ( x - 1 )*10 , -2.1f , ( y - 1 )*10 ), Quaternion.identity);  
            }
        }//Спавн пола.
    objects = new GameObject[3];
    
           for (int i = 0 ; i < 3 ; i++ )
           {
           objects[ i ] = Instantiate( Coin );
           objects[ i ].transform.position = new Vector3( Random.Range( 0 , MazeGenerator.Width - 1 )*10 , 0f , Random.Range( 0 ,MazeGenerator.Length - 1 )*10 );
           }//Спавн монет.
        
    }
    

}
