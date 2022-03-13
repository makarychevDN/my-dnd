using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputFieldStringProvider : StringProvider
{
    [SerializeField] private TMP_InputField inputField;
    
    public override string TakeValue() => inputField.text;
}
