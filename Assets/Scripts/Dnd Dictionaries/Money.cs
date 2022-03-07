using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Money : BaseSynchronizer
{
    [SerializeField] private moneyType type;
    [SerializeField] private TMP_InputField inputField;

    [SerializeField] private int count;
    public int Count
    {
        get => count;
        set
        {
            count = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public void DecreaseCount(int value) => Count -= value;
    public void IncreaseCount(int value) => Count += value;
    
    public void DecreaseCount(IntProvider provider) => Count -= provider.TakeValue();
    public void IncreaseCount(IntProvider provider) => Count += provider.TakeValue();
    

    protected override void Synchronize()
    {
        inputField.text = count.ToString();
    }
}

public enum moneyType
{
    Gold = 1, Silver = 2, Copper = 3
}