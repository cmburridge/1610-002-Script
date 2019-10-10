using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public FloatData health;
    public ClothesData shirt;
    public ClothesData pants;
    public List<WeaponData> weapon;
}
