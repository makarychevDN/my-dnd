using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputFieldIntProvider : IntProvider
{
    [SerializeField] private TMP_InputField inputField;
    
    public override int TakeValue() => Convert.ToInt32(inputField.text);
}
