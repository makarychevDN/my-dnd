using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStats : MonoBehaviour
{
    public static MainStats Instance;
    
    [SerializeField] private int _strength;
    [SerializeField] private int _dexterity;
    [SerializeField] private int _endurance;
    [SerializeField] private int _intelligence;
    [SerializeField] private int _wisdom;
    [SerializeField] private int _charisma;
    
    private int _strengthMod;
    private int _dexterityMod;
    private int _enduranceMod;
    private int _intelligenceMod;
    private int _wisdomMod;
    private int _charismaMod;

    private void Awake()
    {
        Instance = this;
    }

    public int Strength
    {
        get => _strength;
        set
        {
            _strength = value;
            _strengthMod = CalculateModifier(value);
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    public int Dexterity
    {
        get => _dexterity;
        set
        {
            _dexterity = value;
            _dexterityMod = CalculateModifier(value);
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public int Endurance
    {
        get => _endurance;
        set
        {
            _endurance = value;
            _enduranceMod = CalculateModifier(value);
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    public int Intelligence
    {
        get => _intelligence;
        set
        {
            _intelligence = value;
            _intelligenceMod = CalculateModifier(value);
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    public int Wisdom
    {
        get => _wisdom;
        set
        {
            _wisdom = value;
            _wisdomMod = CalculateModifier(value);
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public int Charisma
    {
        get => _charisma;
        set
        {
            _charisma = value;
            _charismaMod = CalculateModifier(value);
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public int StrengthMod => _strengthMod;

    public int DexterityMod => _dexterityMod;

    public int IntelligenceMod => _intelligenceMod;

    public int WisdomMod => _wisdomMod;

    public int CharismaMod => _charismaMod;

    public int EnduranceMod => _enduranceMod;

    private static int CalculateModifier(int value)
    {
        return value / 2 - 5;
    }
}
