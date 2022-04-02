using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorClassSaver : BaseSynchronizer
{
    [SerializeField] private ArmorClass armorClass;

    protected override void Synchronize()
    {
        PlayerPrefs.SetInt("ArmorClass", armorClass.Value);
    }
}
