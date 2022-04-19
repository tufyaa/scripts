using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveCamera : MonoBehaviour
{
   public Transform _camera;  

    void Start()
    {
        _camera.position = new Vector3(MazeGenerator.Width/2 , MazeGenerator.Length/2 , -(MazeGenerator.Width+ 2*MazeGenerator.Length)/3);
        
    }

    
}
