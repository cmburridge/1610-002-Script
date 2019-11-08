using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public bool dead = false;
    public float playerHealth = 1f;
    public GameObject prefab;
    private int healthAmountMin = 0;
    
    public void UpdateValue(float amount)
    {
        playerHealth += amount;
    }


    public void KillPlayer(Component getComponent)
    {
        throw new NotImplementedException();
    }
}



