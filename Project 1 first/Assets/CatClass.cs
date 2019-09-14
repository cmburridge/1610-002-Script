﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{
    public UnityEvent doesThings;
    public UnityEvent doesMore;
    
    private void OnMouseDown()
    {
        doesThings.Invoke();
    }

    private void OnMouseUp()
    {
        doesMore.Invoke();
    }
}
