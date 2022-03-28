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
}
