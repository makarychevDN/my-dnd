using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorStatModificatorSaver : BaseSynchronizer
{
    [SerializeField] private HitSuccessCalculator damageCalculator;

    protected override void Synchronize()
    {
        PlayerPrefs.SetString("LastChosenModificator", damageCalculator.MainStat.ToString());
    }
}
