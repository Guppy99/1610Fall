﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	private CharacterController Controller;
	
	public float Gravity = 9.81f;
	public float MoveSpeed = 3.0f;
	public float JumpSpeed = 3.0f;
	private Vector3 position;
	private Vector3 rotation;

	// Use this for initialization
	void Start ()
	{
		Controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Controller.isGrounded)
		{
			position.Set(0, 0, MoveSpeed*Input.GetAxis("Vertical"));
			rotation.Set(0, Input.GetAxis("Horizontal"), 0);
			transform.Rotate(rotation);
			position = transform.TransformDirection(position);
			
			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
		}
		position.y -= Gravity * Time.deltaTime;
		Controller.Move(position * Time.deltaTime);
	}
}
