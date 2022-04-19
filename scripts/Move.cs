using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
public float Speed = 30f;
private Vector3 moveVelocity;
private Rigidbody rb;
void Start()
{
rb = GetComponent<Rigidbody>();
}
void Update()
{
Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
moveVelocity = moveInput.normalized * Speed;
}
void FixedUpdate()
{
rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
}
}