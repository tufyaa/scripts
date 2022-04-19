using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public GameObject Record ; 
    public GameObject Record2D ; 
    public int s;
    
    public GameObject LastGame ; 
    public GameObject LastGame2D ; 
    
    void Start()
    {

    s = PlayerPrefs.GetInt("score");
    Record.GetComponent<Text>().text = "Record : " + s ;  

    s = PlayerPrefs.GetInt("lastgame");
    LastGame.GetComponent<Text>().text = "Last Game : " + s ; 

    s = PlayerPrefs.GetInt("score2d");
    Record2D.GetComponent<Text>().text = "Record 2D : " + s ;  

    s = PlayerPrefs.GetInt("lastgame2d");
    LastGame2D.GetComponent<Text>().text = "Last Game 2D : " + s ;
    }
    
}
