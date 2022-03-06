using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCharacterDataSynchronizer : MonoBehaviour
{
    private void Awake()
    {
        Character.OnValueChanged.AddListener(UpdateVisualization);
    }

    protected virtual void UpdateVisualization(){}
}
