using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDisplay : MonoBehaviour
{
    public SpriteRenderer rend;

    public void DisplayFunction(WeaponData weaponData)
    {
        rend.sprite = weaponData.sprite;
    }
}
