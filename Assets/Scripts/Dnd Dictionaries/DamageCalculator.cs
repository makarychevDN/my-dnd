using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculator : MonoBehaviour
{
    public static DamageCalculator Instance;
    private List<Damage> _damageStack = new List<Damage>();
    public List<Damage> DamageStack => _damageStack;

    private void Awake()
    {
        Instance = this;
    }

    public void AddDamage(Damage damage)
    {
        _damageStack.Add(damage);
        MyCharacterData.OnValueChanged.Invoke();
    }

    public void ClearDamage()
    {
        _damageStack.Clear();
        MyCharacterData.OnValueChanged.Invoke();
    }

    public int Sum => CalculateSum();

    private int CalculateSum()
    {
        int sum = 0;
        _damageStack.ForEach(damageInstance => sum += damageInstance.Sum);
        return sum;
    }

    public Dictionary<DamageType, int> SumsOfDamageSortedByType()
    {
        Dictionary<DamageType, int> damageSumsSortedByType = new Dictionary<DamageType, int>();

        foreach (var damageInstance in _damageStack)
        {
            if (damageSumsSortedByType.ContainsKey(damageInstance.Type))
            {
                damageSumsSortedByType[damageInstance.Type] += damageInstance.Sum;
            }
            
            else
            {
                damageSumsSortedByType.Add(damageInstance.Type, damageInstance.Sum);
            }
        }

        return damageSumsSortedByType;
    }
    
    public Dictionary<DamageType, List<int>> SumsOfDetailedDamageSortedByType()
    {
        Dictionary<DamageType, List<int>> damageSumsSortedByType = new Dictionary<DamageType, List<int>>();

        foreach (var damageInstance in _damageStack)
        {
            if (damageSumsSortedByType.ContainsKey(damageInstance.Type))
            {
                damageSumsSortedByType[damageInstance.Type] = damageInstance.DamageValues;
            }
            
            else
            {
                damageSumsSortedByType.Add(damageInstance.Type, damageInstance.DamageValues);
            }
        }

        return damageSumsSortedByType;
    }
}
