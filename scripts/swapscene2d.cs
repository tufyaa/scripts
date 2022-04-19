using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class swapscene2d : MonoBehaviour
{
    bool col=false;
    public int y ;
    public double schet = 0;
    void OnTriggerEnter2D()
    {
        col = true;

    }
     void Update()
{
    if (col)
{
    SceneManager.LoadScene(0 );
            if (PlayerPrefs.HasKey("score2d"))
                y = PlayerPrefs.GetInt("score2d");
            else
                y = 0;
            schet = 1000*(MazeGenerator.Width*MazeGenerator.Length + 100*Score._Score)/sec.vremya;
            if (schet >= y)
            {
                PlayerPrefs.SetInt("score2d", Convert.ToInt32(Math.Round(schet)));
            }

            PlayerPrefs.SetInt("lastgame2d", Convert.ToInt32(Math.Round(schet)));
    
            sec.vremya = Score._Score = 0;
}
}
}
