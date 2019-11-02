using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public int dead = 0;
    public float value = 1f;
    public GameObject prefab;

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void killPlayer()
    {
       
    }
        
}



