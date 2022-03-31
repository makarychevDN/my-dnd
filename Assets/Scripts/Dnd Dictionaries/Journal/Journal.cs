using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public static Journal Instance;
    private string data = "";

    public string Data => data;

    private void Awake()
    {
        Instance = this;
    }

    public void AddDataInstance(string dataInstance)
    {
        data = data.Insert(0, $"{DateTime.Now.Hour}:{DateTime.Now.Minute}\n{dataInstance}\n\n");
    }

    public void Clear()
    {
        data = "";
        MyCharacterData.OnValueChanged.Invoke();
    }
}
