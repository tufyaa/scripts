using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acc : MonoBehaviour
{
    
    
    
        private void FixedUpdate()
    {
     Vector3 acceleration = Input.acceleration;
     GetComponent<Rigidbody>().velocity = new Vector3(acceleration.x*30,0f,acceleration.y*30);
        
        
    }
    
}
