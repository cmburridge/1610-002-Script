using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombBehavior : MonoBehaviour
{
    public UnityEvent Click;
    private void OnMouseDown()
    {
        Click.Invoke();
        print("Disarmed bomb");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
