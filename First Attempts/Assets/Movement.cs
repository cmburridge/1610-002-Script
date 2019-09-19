using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 5f;
	public float gravity = 3f;
	public Vector3 position;
	public float jumpSpeed = 4f;
	// Update is called once per frame
	void Update ()
	{
		position.x = speed * Input.GetAxis("Horizontal");
		if (controller.isGrounded)
		{
			position.y = gravity;
		}
		controller.Move(position * Time.deltaTime);
		position.y -= gravity;
		if (Input.GetButtonDown("Jump"))
		{
			position.y = jumpSpeed;
		}
	}
}
