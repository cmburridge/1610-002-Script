using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyOne1 : MonoBehaviour
{
   
    public Vector3 move;
    public Rigidbody enemy;

    void Update()
    {
       transform.Translate(move*Time.deltaTime);
        enemy.MovePosition(move*Time.deltaTime);
    }
    
}
