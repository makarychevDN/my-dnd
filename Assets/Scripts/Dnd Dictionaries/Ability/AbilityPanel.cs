using System;
using TMPro;
using UnityEngine;

public class AbilityPanel : BaseSynchronizer
{
    [SerializeField] private Ability ability;
    [SerializeField] private TMP_InputField abilityName;
    [SerializeField] private TMP_InputField diceCount;
    [SerializeField] private TMP_InputField diceValue;
    [SerializeField] private TMP_InputField additionDamage;
    [SerializeField] private TMP_Dropdown damageType;

    public Ability Ability
    {
        get => ability;
        set
        {
            ability = value;
            Synchronize();
        }
    }

    protected override void Synchronize()
    {
        abilityName.text = ability.AbilityName;
        diceCount.text = ability.DiceCount.ToString();
        diceValue.text = ability.DiceValue.ToString();
        additionDamage.text = ability.AdditionDamage.ToString();
        damageType.value = (int)ability.DamageType;
    }
    
    public void SetName(StringProvider provider) => ability.AbilityName = provider.TakeValue();
    
    public void SetDiceValue(IntProvider provider) => ability.DiceValue = provider.TakeValue();
    
    public void SetDiceCount(IntProvider provider) => ability.DiceValue = provider.TakeValue();
    
    public void SetDiceAdditionDamage(IntProvider provider) => ability.DiceValue = provider.TakeValue();
    
    public void SetDiceDamageType(DamageTypeProvider provider) => ability.DamageType = provider.TakeValue();
}
