using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;
     public void Clicksound()
     {
         myFx.PlayOneShot(clickFx);
     }
}
