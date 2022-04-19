using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minush : MonoBehaviour
{
    public Text _Length;
    void Start()
    {
       MazeGenerator.Length = 10;
       
    }
    public void Add()
    {
        if (MazeGenerator.Length > 3 )
        MazeGenerator.Length--;
        _Length.text =  "Width   " + MazeGenerator.Length.ToString();
    }
     
}
