using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSynchronizer : MonoBehaviour
{
    private void Awake()
    {
        MyCharacterData.OnValueChanged.AddListener(Synchronize);
    }

    protected virtual void Synchronize(){}
}
