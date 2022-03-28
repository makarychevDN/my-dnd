using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageCalculatorPanel : BaseSynchronizer
{
    [SerializeField] private TMP_Text damageSumLabel;
    [SerializeField] private TMP_Text damageLabel;
    
    protected override void Synchronize()
    {
        damageSumLabel.text = DamageCalculator.Instance.Sum.ToString();
    }
}
