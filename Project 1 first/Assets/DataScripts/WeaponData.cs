using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class WeaponData : GameArtData
{
    public int powerLevel = 10;
    public UnityEvent onActivate;


    public void Activate()
    {
        onActivate.Invoke();
    }
}
