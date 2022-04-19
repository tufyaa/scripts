using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{   
    
    public static int _Score=0;
    public int sum ; 
     
public GameObject TextScore;
void start()
{
    sum = Convert.ToInt32(Math.Round(1000*(MazeGenerator.Width*MazeGenerator.Length + 100*_Score)/sec.vremya)) ; 
    
   TextScore.GetComponent<Text>().text =  "Score: " + sum.ToString() ; 
}
void Update()
{
   
    
    
    sum = Convert.ToInt32(Math.Round(1000*(MazeGenerator.Width*MazeGenerator.Length + 100*_Score)/sec.vremya)) ;
    
       
    TextScore.GetComponent<Text>().text =  "Score: " + sum.ToString() ;
    
}

}
