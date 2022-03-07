using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputFieldSynchronizer : BaseSynchronizer
{
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Key key;

    protected override void Synchronize()
    {
        /*if (MyCharacterData.Instance.Get(key).ToString() == inputField.text)
            return;

        inputField.text = MyCharacterData.Instance.Get(key).ToString();*/
    }
}
