using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Rubber : MonoBehaviour
{
	public Vector3 bouncy;
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	private void OnCollisionEnter(Collision other)
	{
		rb.AddForce(bouncy);
	}
}
