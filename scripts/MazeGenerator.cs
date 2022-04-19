using System;
using System.Collections.Generic;
using UnityEngine;



public class MazeGenerator
{
    static public int Width = 15;
    static public int Length = 10 ;
    // Параметры лабиринта.

    public Maze GenerateMaze()
    {
        MazeGeneratorCell[,] cells = new MazeGeneratorCell[Width, Length];
        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                cells[i, j] = new MazeGeneratorCell {X = i, Y = j};
            }
        }//Позволяет заполнить все поле клетками. Впоследствии ненужные стены будут удалены.

        for (int x = 0; x < cells.GetLength(0); x++)
            cells[x, Length - 1].WallLeft = false;

        for (int y = 0; y < cells.GetLength(1); y++)
            cells[Width - 1, y].WallBottom = false;
        //В этих двух цикалах удаляются торчащие стены. 

        RemoveWalls(cells);

        Maze maze = new Maze();

        maze.cells = cells;
        maze.finishPosition = PlaceMazeExit(cells);

        return maze;
    }

    private void RemoveWalls(MazeGeneratorCell[,] maze)
    {
        MazeGeneratorCell current = maze[0, 0];
        current.Visited = true;
        current.DistanceFromStart = 0;

        Stack<MazeGeneratorCell> stack = new Stack<MazeGeneratorCell>();
        do
        {
            List<MazeGeneratorCell> unvisited = new List<MazeGeneratorCell>();

            int x = current.X;
            int y = current.Y;

            if (x > 0 && !maze[x - 1, y].Visited) 
            unvisited.Add(maze[x - 1, y]);

            if (y > 0 && !maze[x, y - 1].Visited) 
            unvisited.Add(maze[x, y - 1]);

            if (x < Width - 2 && !maze[x + 1, y].Visited) 
            unvisited.Add(maze[x + 1, y]);

            if (y < Length - 2 && !maze[x, y + 1].Visited) 
            unvisited.Add(maze[x, y + 1]);

            //Мы проверяем соседей на посещенность и добавляем в список нужные элементы (непосещенные клетки).


            if (unvisited.Count > 0)
            {
                MazeGeneratorCell chosen = unvisited[UnityEngine.Random.Range(0, unvisited.Count)];
                RemoveWall(current, chosen);

                chosen.Visited = true;
                stack.Push(chosen);
                chosen.DistanceFromStart = current.DistanceFromStart + 1;
                current = chosen;
            }
            else
            {
                current = stack.Pop();
            }
        } while (stack.Count > 0);
    }

    private void RemoveWall(MazeGeneratorCell a, MazeGeneratorCell b)
    {
        if (a.X == b.X)
        {
            if (a.Y > b.Y) a.WallBottom = false;
            else b.WallBottom = false;
        }
        else
        {
            if (a.X > b.X) a.WallLeft = false;
            else b.WallLeft = false;
        }
    }

    private Vector2Int PlaceMazeExit(MazeGeneratorCell[,] maze)
    {
        MazeGeneratorCell LongestDistance = maze[0, 0];

        for (int x = 0; x < maze.GetLength(0); x++)
        {
            for (int y = 0; y < maze.GetLength(1); y++)
            {
            if (maze[x, y].DistanceFromStart > LongestDistance.DistanceFromStart) 
            LongestDistance = maze[x, y];
            }
            
        }

       
        LongestDistance.Exit=true;
        
        return new Vector2Int(LongestDistance.X, LongestDistance.Y);
    }
}

