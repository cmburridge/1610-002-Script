using System;
using System.Runtime.InteropServices;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public GameObject player;
    public bool dead = false;
   
    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void KillPlayer(float amount)
    {
        if (value <= 0)
        {
            dead = true;
        }

    }
    
    
}
