using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class minusw : MonoBehaviour
{
    public Text _Width;
    void Start()
    {
        MazeGenerator.Width = 15;
        
    }
    public void Add()
    {   if (MazeGenerator.Width > 3 )
        MazeGenerator.Width--;
        _Width.text =  "Length    "+MazeGenerator.Width.ToString() ;
    }
}
