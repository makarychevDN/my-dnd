using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class СharacterСharacteristicIncreaser : MonoBehaviour
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private bool decrease;
    public CharacterKey valueKey;

    public void Calculate()
    {
        if (!decrease)
            Character.Increase(valueKey, Convert.ToInt32(inputField.text));
        else
            Character.Decrease(valueKey, Convert.ToInt32(inputField.text));
    }
}
