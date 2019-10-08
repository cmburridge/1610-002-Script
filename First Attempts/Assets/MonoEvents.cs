using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{

	public UnityEvent Startevent;
	void Start () 
	{
		Startevent.Invoke();
	}
	
}
