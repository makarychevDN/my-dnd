using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputFieldSynchronizer : BaseSynchronizer
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private DataKey dataKey;

    protected override void Synchronize()
    {
        if (MyCharacterData.Get(dataKey).ToString() == inputField.text)
            return;

        inputField.text = MyCharacterData.Get(dataKey).ToString();
    }
}
