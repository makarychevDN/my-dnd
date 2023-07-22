using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class AbilitiesSaver : BaseSynchronizer
{
    [SerializeField] private Abilities abilities;
        
    protected override void Synchronize()
    {
        PlayerPrefs.SetString("Abilities", SkillsToString());
    }

    private string SkillsToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var ability in abilities.AbilitiesList)
        {
            sb.Append(
                $"{ability.AbilityName}`{ability.DamageType}`{ability.DiceCount}`{ability.DiceValue}`{ability.AdditionDamage}~");
        }
        
        if(sb.Length != 0)
            sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}