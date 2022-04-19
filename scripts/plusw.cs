using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plusw : MonoBehaviour
{
    public Text _Width;
   
    public void Add()
    {
        if (MazeGenerator.Width < 80 )
    MazeGenerator.Width++;
    _Width.text =  "Length    "+MazeGenerator.Width.ToString() ;
    }
}
