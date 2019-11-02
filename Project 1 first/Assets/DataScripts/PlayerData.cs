using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PlayerData : GameArtData
{
    public FloatData health;
    public ClothesData shirt;
    public ClothesData pants;
    public List<WeaponData> weapon;
    public UnityEvent onRun;
    
    public void instancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var playerSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        playerSprite.sprite = sprite;
        playerSprite.color = color; 
    }


    public void Run()
    {
        onRun.Invoke();
    }

    
}
