using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class swapscene : MonoBehaviour
{
    bool col=false;
    public int x ;
    public double schet = 0;
    void OnTriggerEnter()
    {
        col = true;
    }

     void Update()
    {
        if (col)
        {
            SceneManager.LoadScene(0 );
            
            if (PlayerPrefs.HasKey("score"))
                x = PlayerPrefs.GetInt("score");
            else
                x = 0;
            schet = 1000*(MazeGenerator.Width*MazeGenerator.Length + 100*Score._Score)/sec.vremya;
            if (schet >= x)
            {
                PlayerPrefs.SetInt("score", Convert.ToInt32(Math.Round(schet)));
            }
            PlayerPrefs.SetInt("lastgame", Convert.ToInt32(Math.Round(schet)));
    
            sec.vremya = Score._Score = 0;
        }
    }
}
