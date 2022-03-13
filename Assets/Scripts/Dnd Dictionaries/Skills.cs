using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public static Skills Instance;
    public List<Skill> skills;

    private void Awake()
    {
        Instance = this;
        MyCharacterData.OnValueChanged.Invoke();
    }
}
