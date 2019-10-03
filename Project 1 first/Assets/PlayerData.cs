using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
   public float speed = 1f;
   public float jumpSpeed = 1f;
   public float defense = 1f;
   public float magic = 1f;
   public float size = 1f;
   public bool canJump = true;
   public bool canSwim = true;
   
}
