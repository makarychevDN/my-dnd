using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class KeyboardTypeSwaper : MonoBehaviour
{
    [SerializeField] private TouchScreenKeyboardType type;
    public void Swap() => TouchScreenKeyboard.Open("", type);
}

