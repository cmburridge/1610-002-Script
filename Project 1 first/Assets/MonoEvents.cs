using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.WSA.Input;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent Startevent;
    // Start is called before the first frame update
    void Start()
    {
        Startevent.Invoke();
    }

   
}
