using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
	public bool dead = false;
	public CharacterController player;
	public float HealthAmount = 1f;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (HealthAmount <= 0)
		{
			dead = true;
		}
		
	}

}

