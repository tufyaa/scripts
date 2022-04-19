using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{

[SerializeField] private GameObject _object; 
[SerializeField] private Vector3 _distanceFromObject; 
Event function;
void Start()
{
_distanceFromObject = transform.position - _object.transform.position;
}

private void LateUpdate()
{
Vector3 positionToGo = _object.transform.position + _distanceFromObject; //Target position of the camera
Vector3 smoothPosition = Vector3.Lerp(a: transform.position, b: positionToGo, t: 0.125F); //Smooth position of the camera
transform.position = smoothPosition;
//transform.LookAt(_object.transform.position); //Camera will look(returns) to the object
}
}
