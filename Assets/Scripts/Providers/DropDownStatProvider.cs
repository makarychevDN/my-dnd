using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DropDownStatProvider : StatProvider
{
    [SerializeField] private TMP_Dropdown dropdown;
    
    public override Stats TakeValue()
    {
        Enum.TryParse(dropdown.options[dropdown.value].text, out Stats temp);
        return temp;
    }
}
