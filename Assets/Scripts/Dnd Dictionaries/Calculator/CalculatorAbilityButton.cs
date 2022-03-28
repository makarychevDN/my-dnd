using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalculatorAbilityButton : BaseSynchronizer
{
    [SerializeField] private Ability ability;
    [SerializeField] private TMP_Text textLabel;
    
    protected override void Synchronize()
    {
        textLabel.text = ability.AbilityName;
    }
    
    public Ability Ability
    {
        get => ability;
        set
        {
            ability = value;
            Synchronize();
        }
    }

    public void AddDamage()
    {
        DamageCalculator.Instance.AddDamage(new Damage(ability.DamageType, ability.DiceCount, ability.DiceValue, ability.AdditionDamage));
    }
} 
