using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTypeSwaper : MonoBehaviour
{
    private TouchScreenKeyboard keyboard;

    /*protected void OnGUI()
    {
        GUI.skin.button.fontSize = 36;
        if (GUILayout.Button("Keyboard"))
        {
            keyboard = TouchScreenKeyboard.Open("Hello", TouchScreenKeyboardType.Default);
        }
    }*/

    private void Start()
    {
        TouchScreenKeyboard.Open("wow");
    }
}
