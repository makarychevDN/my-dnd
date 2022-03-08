using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyPanel : BaseSynchronizer
{
    [SerializeField] private MoneyType type;
    [SerializeField] private TMP_InputField inputField;

    public void DecreaseCount(int value) => Money.Instance.SetCount(type, Money.Instance.GetCount(type) - value);
    public void IncreaseCount(int value) => Money.Instance.SetCount(type, Money.Instance.GetCount(type) + value);
    
    public void DecreaseCount(IntProvider provider) => DecreaseCount(provider.TakeValue());
    public void IncreaseCount(IntProvider provider) => IncreaseCount(provider.TakeValue());
    

    protected override void Synchronize()
    {
        inputField.text = Convert.ToString(Money.Instance.GetCount(type));
    }
}