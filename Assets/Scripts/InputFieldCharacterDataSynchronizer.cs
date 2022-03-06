using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputFieldCharacterDataSynchronizer : BaseCharacterDataSynchronizer
{
    [SerializeField] private CharacterKey characterKey;
    [SerializeField] private TMP_InputField inputField;

    protected override void UpdateVisualization()
    {
        inputField.text = Character.Get(characterKey).ToString();
    }
}
