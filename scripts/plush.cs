using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plush : MonoBehaviour
{
    public Text _Length;
   
    public void Add()
    {
        if (MazeGenerator.Length < 80 )
        MazeGenerator.Length++;
        _Length.text =  "Width   " + MazeGenerator.Length.ToString() ;
    }
}
