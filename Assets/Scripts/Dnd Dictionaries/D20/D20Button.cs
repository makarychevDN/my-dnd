using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D20Button : MonoBehaviour
{
    [SerializeField] private D20Mode mode;
    
    public void Roll()
    {
        DamageCalculator.Instance.ClearDamage();
    }
}

public enum D20Mode
{
    Default, Advantage, Disadvantage
}
