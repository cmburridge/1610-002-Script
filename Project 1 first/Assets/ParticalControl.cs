using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalControl : MonoBehaviour
{
    public ParticleSystem particles;

    private void OnMouseDown()
    {
        particles.Emit(100);
    }
}
