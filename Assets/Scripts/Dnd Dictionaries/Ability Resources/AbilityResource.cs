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
            if(currentCount == value)
                return;

            int hashedValue = currentCount;
            currentCount = value;
            currentCount = Mathf.Clamp(currentCount, 0, maxCount);
            
            if (currentCount < hashedValue)
            {
                Journal.Instance.AddDataInstance($"потрачено {hashedValue - currentCount} {name} ({hashedValue} => {currentCount})");
            }

            if (currentCount > hashedValue)
            {
                Journal.Instance.AddDataInstance($"восстановлено {currentCount - hashedValue} {name} ({hashedValue} => {currentCount})");
            }
            
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

    public void Init(string name, int maxCount, int currentCount)
    {
        this.name = name;
        this.maxCount = maxCount;
        this.currentCount = currentCount;
    }
}
