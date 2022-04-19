using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class del : MonoBehaviour
{
public GameObject player;
//public int Score=0;
//public GameObject TextScore;
private void OnTriggerEnter(Collider collision)
{
    Score._Score++;
    //TextScore.GetComponent<Text>().text =  Score.ToString()+" Coins collected" ;
Destroy(gameObject);
MazeSpawner.count++;

}
} 
