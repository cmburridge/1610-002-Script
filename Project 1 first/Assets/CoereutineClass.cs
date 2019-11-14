using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoereutineClass : MonoBehaviour
{
    public bool canRun = true;
    public IntData index;
    public float seconds = 1f;
    private WaitForSeconds wfsobj;
    
    public void Run()
    {
        wfsobj = new WaitForSeconds(seconds);
        StartCoroutine(OnRun());
    }

    IEnumerator OnRun()
    {
        while (index.value > 0)
        {
             Debug.Log(index.value);
             index.value--;
             yield return wfsobj;
        }
    }
}
