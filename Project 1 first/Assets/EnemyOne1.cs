using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class EnemyOne1 : GameArtData
{
    public Transform placement;
    public Vector3 move;
    public Rigidbody enemy;

    void Update()
    {
        placement.Translate(move*Time.deltaTime);
        enemy.MovePosition(move*Time.deltaTime);
    }
    public void instanceEnemy()
    {
        var enemy1 = Instantiate(prefab);
        var enemySprite = enemy1.GetComponentInChildren<SpriteRenderer>();
        enemySprite.sprite = sprite;
        enemySprite.color = color;
 
    }
}

