using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D20Button : MonoBehaviour
{
    [SerializeField] private D20Mode mode;
    
    public void Roll()
    {
        DamageCalculator.Instance.ClearDamage();
        HitSuccessCalculator.Instance.Roll(mode);
    }
}

public enum D20Mode
{
    Default, Advantage, Disadvantage
}
