using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
	public UnityEvent value;
	public void OnTriggerEnter(Collider other)
	{
		value.Invoke();
	}
}
