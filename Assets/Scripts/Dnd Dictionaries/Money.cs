using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public static Money Instance;

    [SerializeField] private List<MoneyUnit> inputMoneyUnits;
    private Dictionary<MoneyType, int> _moneyUnits;

    private Dictionary<MoneyType, string> moneyFormatStrings = new Dictionary<MoneyType, string>()
    {
        {MoneyType.Gold, "зм"},
        {MoneyType.Silver, "см"},
        {MoneyType.Copper, "мм"},
    };

    public Dictionary<MoneyType, int> MoneyUnits => _moneyUnits;

    public void SetCount(MoneyType key, int value)
    {
        Journal.Instance.AddDataInstance($"установлено значение {moneyFormatStrings[key]} в {value} (было {_moneyUnits[key]})");
        _moneyUnits[key] = value;
        MyCharacterData.OnValueChanged.Invoke();
    }

    public int GetCount(MoneyType key) => _moneyUnits[key];

    public void IncreaseCount(MoneyType key, int value)
    {
        Journal.Instance.AddDataInstance(
            $"получено {value} {moneyFormatStrings[key]} ({_moneyUnits[key]} => {_moneyUnits[key] + value})");
        _moneyUnits[key] += value;
        MyCharacterData.OnValueChanged.Invoke();
    }
    
    public void DecreaseCount(MoneyType key, int value)
    {
        Journal.Instance.AddDataInstance(
            $"потрачено {value} {moneyFormatStrings[key]} ({_moneyUnits[key]} => {_moneyUnits[key] - value})");
        _moneyUnits[key] -= value;
        MyCharacterData.OnValueChanged.Invoke();
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (PlayerPrefs.HasKey(MoneyType.Gold.ToString()) && 
            PlayerPrefs.HasKey(MoneyType.Silver.ToString()) &&
            PlayerPrefs.HasKey(MoneyType.Copper.ToString()))
        {
            InitFromPlayerPrefs();
            return;
        }

        InitFromInspectorData();
    }

    private void InitFromPlayerPrefs()
    {
        _moneyUnits = new Dictionary<MoneyType, int>();
        _moneyUnits.Add(MoneyType.Gold, PlayerPrefs.GetInt(MoneyType.Gold.ToString()));
        _moneyUnits.Add(MoneyType.Silver, PlayerPrefs.GetInt(MoneyType.Silver.ToString()));
        _moneyUnits.Add(MoneyType.Copper, PlayerPrefs.GetInt(MoneyType.Copper.ToString()));
    }

    private void InitFromInspectorData()
    {
        _moneyUnits = new Dictionary<MoneyType, int>();

        foreach (var VARIABLE in inputMoneyUnits)
        {
            _moneyUnits.Add(VARIABLE.key, VARIABLE.count);
        }
    }
}

[Serializable]
public struct MoneyUnit
{
    public MoneyType key;
    public int count;
}

public enum MoneyType
{
    Gold = 1, Silver = 2, Copper = 3
}