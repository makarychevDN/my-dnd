using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyCharacterData : MonoBehaviour
{
    public static UnityEvent OnValueChanged = new();
    
    private static int _health;
    private static int _maxHealth = 100;
    private static int _gold;
    private static int _silver;
    private static int _copper;

    private static Dictionary<DataKey, int> Dictionary= new()
    {
        {DataKey.Health, _health},
        {DataKey.MaxHealth, _maxHealth},
        {DataKey.Gold, _gold},
        {DataKey.Silver, _silver},
        {DataKey.Copper, _copper}
    };

    public static void Set(DataKey key, int value)
    {
        Dictionary[key] = value;
        OnValueChanged.Invoke();
    }
    
    public static int Get(DataKey key)
    {
        return Dictionary[key];
    }

    public static void Increase(DataKey key, int value)
    {
        Dictionary[key] += value;
        OnValueChanged.Invoke();
    }
    
    public static void Decrease(DataKey key, int value)
    {
        Dictionary[key] -= value;
        OnValueChanged.Invoke();
    }
}

public enum DataKey
{
    Health = 1,
    Gold = 2,
    Silver = 3,
    Copper = 4,
    MaxHealth = 5
}