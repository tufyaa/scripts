using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sec : MonoBehaviour
{
    static public float vremya=1;
    public float vr = 0 ; 

    void Update()
    {
        vr += Time.deltaTime;
        if (vr > vremya + 1 )
        vremya = vr ; 
        
    }
}
