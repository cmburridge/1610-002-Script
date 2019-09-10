using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Behaviors : MonoBehaviour
{

	public float floatValue = 5f;

	public int intValue = 20;
	public UnityEvent platform;
	private void OnCollisionEnter(Collision other)
	{
		platform.Invoke();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
