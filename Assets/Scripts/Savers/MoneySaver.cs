using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneySaver : BaseSynchronizer
{
    [SerializeField] private Money money;
        
    protected override void Synchronize()
    {
        PlayerPrefs.SetInt(MoneyType.Gold.ToString(), money.MoneyUnits[MoneyType.Gold]);
        PlayerPrefs.SetInt(MoneyType.Silver.ToString(), money.MoneyUnits[MoneyType.Silver]);
        PlayerPrefs.SetInt(MoneyType.Copper.ToString(), money.MoneyUnits[MoneyType.Copper]);
    }
}
