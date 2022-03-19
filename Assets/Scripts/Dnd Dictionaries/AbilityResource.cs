using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityResource : MonoBehaviour
{
    [SerializeField] private new string name;
    [SerializeField] private int currentCount;
    [SerializeField] private int maxCount;
    
    public string Name
    {
        get => name;
        set
        { 
            name = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    public int Count
    {
        get => currentCount;
        set
        { 
            currentCount = value;
            currentCount = Mathf.Clamp(currentCount, 0, maxCount);
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    public int MaxCount
    {
        get => maxCount;
        set
        { 
            maxCount = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
}
