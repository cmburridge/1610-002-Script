using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOne1 : MonoBehaviour
{
    public Vector3 move;
    public Rigidbody enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move*Time.deltaTime);
        enemy.MovePosition(move*Time.deltaTime);
    }
}
