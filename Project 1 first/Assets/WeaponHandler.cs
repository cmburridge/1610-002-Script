using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    public WeaponData weaponDataObj;

    public void WeaponSwitch(WeaponData data)
    {
        weaponDataObj = data;
    }

    public void onActivate()
    {
        weaponDataObj.Activate();
    }
    

}
