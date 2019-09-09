using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
	
	public float floatValue = 5f;
	public int intValue = 20;
	public string stringValue = "Jon";
	public UnityEvent Event;
	

	public void OnTriggerEnter(Collider other)
	{
		throw new NotImplementedException();
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
