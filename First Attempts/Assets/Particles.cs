using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Particles : MonoBehaviour
{
	public UnityEvent emitParticles;

	private void OnMouseDown()
	{
		emitParticles.Invoke();
	}
}
