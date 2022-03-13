using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class InputFieldLettersRemover : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    
    private void Awake()
    {
        if(_inputField == null)
            _inputField = GetComponent<TMP_InputField>();
    }

    public void RemoveLetters()
    {
        _inputField.text =
            $"{(_inputField.text[0] == '-' ? "-" : "")}{new string(_inputField.text.Where(chr => (char.IsNumber(chr))).ToArray())}";
    }
}
