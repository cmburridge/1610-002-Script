using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public float speed = 1f;
    public float height = 1f;
    public float weight = 1f;
    public float jumpSpeed = 1f;
    public float strength = 1f;
    public float defense = 1f;
    public float magic = 1f;
    public float charisma = 1f;
    public bool backFlip = true;
    public bool cold = true;
    public bool canJump = true;
    public bool canSwim = true;
    public bool weaponEquipped = true;
    public bool canDie = true;
    public bool hidden = true;


}