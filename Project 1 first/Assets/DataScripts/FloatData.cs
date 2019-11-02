using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public bool dead = false;
    public float value = 1f;
    public GameObject prefab;
    private int healthAmountMin = 0;
    
    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void killPlayer()
    {
        if (value == healthAmountMin)
        {
            
        }
    }
        
}



