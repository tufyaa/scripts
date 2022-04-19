using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Width : MonoBehaviour
{
    

    public GameObject _Width;
    
    public void Start()
    {
        _Width.GetComponent<Text>().text =  "Width    "+MazeGenerator.Width.ToString() ;
    }
}
