using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControl : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    

    public float acc = 1f;
    public Rigidbody2D rb;
    Vector2 vx = new Vector2(1f , 0);
    Vector2 vy = new Vector2(0 , 1f);
    public GameObject cube;
    public int s = 1; 
    
    void Start()
    { 
    rb = cube.GetComponent<Rigidbody2D>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
       if (switchcontroller.da%2==0)
       {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            if (eventData.delta.x > 0)
                rb.AddForce(vx * acc, ForceMode2D.Impulse);
           
            else  
                rb.AddForce(vx * -acc, ForceMode2D.Impulse);
            
        }
        else
        {
            if (eventData.delta.y > 0)
                rb.AddForce(vy * acc, ForceMode2D.Impulse);
            
            else 
                rb.AddForce(vy * -acc, ForceMode2D.Impulse);
            
        }
    }
    else
    {
        if (Mathf.Abs(eventData.delta.x) > Mathf.Abs(eventData.delta.y))
        {
            if (eventData.delta.x > 0)
                rb.velocity = new Vector2(s,0);
           
            else  
                 rb.velocity = new Vector2(-s,0);
        }
        else
        {
            if (eventData.delta.y > 0)
            
                rb.velocity = new Vector2(0,s);
            
            else  
                 rb.velocity = new Vector2(0,-s);
            
        }
    }
    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}

