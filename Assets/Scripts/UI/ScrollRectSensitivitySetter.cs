using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectSensitivitySetter : MonoBehaviour
{
    [SerializeField] private ScrollRect scrollRect;
    [SerializeField] private float sensitivity;

    private void OnValidate()
    {
        scrollRect.scrollSensitivity = sensitivity;
    }
}
