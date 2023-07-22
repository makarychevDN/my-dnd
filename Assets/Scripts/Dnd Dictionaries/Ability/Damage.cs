using System;
using System.Collections.Generic;
using UnityEngine;

public class Damage
{
    [SerializeField] private string sourceName;
    [SerializeField] private DamageType damageType;
    [SerializeField] private int sum;
    [SerializeField] private List<int> damageValues;

    public Damage(DamageType damageType, int diceCount, int diceValue, int additionDamage, string sourceName)
    {
        this.damageType = damageType;
        this.sourceName = sourceName;
        
        damageValues = new List<int>();

        for (int i = 0; i < diceCount; i++)
        {
            var tempDamage = UnityEngine.Random.Range(1, diceValue + 1);
            damageValues.Add(tempDamage);
            sum += tempDamage;
        }
        
        if(additionDamage == 0)
            return;
        
        damageValues.Add(additionDamage);
        sum += additionDamage;
    }

    public DamageType Type => damageType;

    public int Sum => sum;

    public List<int> DamageValues => damageValues;

    public string SourceName => sourceName;
}

[Serializable]
public enum DamageType
{
    рубящий = 0,
    колющий = 1,
    дробящий = 2,
    кислота = 3,
    холод = 4,
    огонь = 5,
    силовой = 6,
    электричество = 7,
    некротический = 8,
    яд = 9,
    псиурон = 10,
    излучение = 11,
    звук = 12,
    исцеление = 13
}
