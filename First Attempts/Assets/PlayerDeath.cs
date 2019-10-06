using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{

	public CharacterController player;
	public float HealthAmount = 1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (HealthAmount >= 0)
		{
			player = Destroy();
		}
		
	}

	private CharacterController Destroy()
	{
		throw new System.NotImplementedException();
	}
}

