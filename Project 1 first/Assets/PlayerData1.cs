using UnityEngine;

[CreateAssetMenu]
public class PlayerData1 : GameArtData
{
    public WeaponData weapon;
    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.color = color;
        newSprite.color = color;
    }
}
