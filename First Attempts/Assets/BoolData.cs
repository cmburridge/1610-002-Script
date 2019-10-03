using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject {

	public bool factor = true;
    
	public void UpdateValue(bool value)
	{
		factor = value;
	}
	
	
	
}
