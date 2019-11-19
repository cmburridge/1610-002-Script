using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class UiTextController : MonoBehaviour
{
    public UnityEvent startEvent;
    private Text textLabel;
    public UnityEvent down;
    
    public void UpdateText(IntData data)
    {
        textLabel.text = data.value.ToString();
    }

    private void Update()
    {
        down.Invoke();
    }

    void Awake()
    {
        textLabel = GetComponent<Text>();
        startEvent.Invoke();
    }

   
  
}
