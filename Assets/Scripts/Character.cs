using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class Character
{
    public static UnityEvent OnValueChanged = new();
    
    private static int _health;
    private static int _gold;
    private static int _silver;
    private static int _copper;

    private static Dictionary<CharacterKey, int> Dictionary= new()
    {
        {CharacterKey.Health, _health},
        {CharacterKey.Gold, _gold},
        {CharacterKey.Silver, _silver},
        {CharacterKey.Copper, _copper}
    };

    public static void Set(CharacterKey key, int value)
    {
        Dictionary[key] = value;
        OnValueChanged.Invoke();
    }
    
    public static int Get(CharacterKey key)
    {
        return Dictionary[key];
    }

    public static void Increase(CharacterKey key, int value)
    {
        Dictionary[key] += value;
        OnValueChanged.Invoke();
    }
    
    public static void Decrease(CharacterKey key, int value)
    {
        Dictionary[key] -= value;
        OnValueChanged.Invoke();
    }
}

public enum CharacterKey
{
    Health = 1, Gold = 2, Silver = 3, Copper = 4
}
