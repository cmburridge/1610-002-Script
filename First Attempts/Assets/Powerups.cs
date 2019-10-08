using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Powerups : ScriptableObject
{

	public float HealthAmount = 1f;
	public float minValue = 0;
	public float maxValue = 1f;


	public void UpdateValue(float amount)
	{
		HealthAmount += amount;
	}

	public void UpdateValueRange(float amount)
	{
		if (HealthAmount <= maxValue)
		{
			UpdateValue(amount);
		}

		if (HealthAmount >= minValue)
		{
			UpdateValue(amount);
		}
		else
		{
			HealthAmount = minValue;
		}
	}

}
		

		
	
