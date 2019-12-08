using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Warp : MonoBehaviour
{
    
    public Vector3 location;

    public void Teleport()
    {
        transform.Translate(location);
    }

    void Update()
    {
        
    }
}
