using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 5f;
	public float gravity = 3f;
	public Vector3 position;
	public float jumpSpeed = 2f;
	private int jumpCount;
	public int jumpCountMax = 2;

	public void Start()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update ()
	{
		position.x = speed * Input.GetAxis("Horizontal");
		position.y -= gravity;

		if (controller.isGrounded)
		{
			position.y = 0;
			jumpCount = 0;
		}

		if (Input.GetButtonDown("Jump"))
		{
			jumpCount++;
		}
		
		if (Input.GetButtonDown("Jump") && (jumpCount < jumpCountMax))
		{
			position.y = jumpSpeed;
		}
		controller.Move(position * Time.deltaTime);
	
	}
}
