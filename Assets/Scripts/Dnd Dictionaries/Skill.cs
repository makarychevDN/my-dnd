using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    [SerializeField] private string name;
    [SerializeField] private int value;
    
    public string Name
    {
        get => name;
        set
        { 
            name = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    public int Value
    {
        get => value;
        set
        { 
            this.value = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
}
