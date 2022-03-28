using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    [SerializeField] private string abilityName;
    [SerializeField] private int diceCount;
    [SerializeField] private int diceValue;
    [SerializeField] private int additionDamage;
    [SerializeField] private DamageType damageType;


    public string AbilityName
    {
        get => abilityName;
        set
        {
            abilityName = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public int DiceCount
    {
        get => diceCount;
        set
        {
            diceCount = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public int DiceValue
    {
        get => diceValue;
        set
        {
            diceValue = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public int AdditionDamage
    {
        get => additionDamage;
        set
        {
            additionDamage = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public DamageType DamageType
    {
        get => damageType;
        set => damageType = value;
    }
}
