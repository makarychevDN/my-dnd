using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnStartUnityEvent : MonoBehaviour
{
    public UnityEvent UnityEvent;
    
    void Start()
    {
        UnityEvent.Invoke();
    }
}
