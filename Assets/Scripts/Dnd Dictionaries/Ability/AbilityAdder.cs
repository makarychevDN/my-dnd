using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityAdder : MonoBehaviour
{
    [SerializeField] private Ability defaultAbility;
    
    public void Add()
    {
        var newAbility = Instantiate(defaultAbility, Skills.Instance.transform);
        newAbility.name = defaultAbility.AbilityName;
        newAbility.AbilityName = defaultAbility.AbilityName;
        newAbility.DiceValue = defaultAbility.DiceValue;
        newAbility.DiceCount = defaultAbility.DiceCount;
        newAbility.AdditionDamage = defaultAbility.AdditionDamage;
        newAbility.DamageType = defaultAbility.DamageType;
        Abilities.Instance.AddAbility(newAbility);    
    }
}
