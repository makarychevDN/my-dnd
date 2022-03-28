using System;
using TMPro;
using UnityEngine;

public class DropDownInputDamageTypeProvider : DamageTypeProvider
{
    [SerializeField] private TMP_Dropdown dropdown;
    
    public override DamageType TakeValue()
    {
        Enum.TryParse(dropdown.options[dropdown.value].text, out DamageType temp);
        return temp;
    }
}
