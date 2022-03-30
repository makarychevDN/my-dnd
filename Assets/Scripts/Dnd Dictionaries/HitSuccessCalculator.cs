using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class HitSuccessCalculator : BaseSynchronizer
{
    public static HitSuccessCalculator Instance;
    private int rollResult = 0;
    private Stats mainStat = Stats.сила;
    private int mainStatValue;

    private void Awake()
    {
        Instance = this;
    }

    public void Roll(D20Mode mode)
    {
        List<int> Rolls = new List<int>() {Random.Range(1, 21), Random.Range(1, 21)};

        if (mode == D20Mode.Advantage)
            rollResult = Rolls.Max();
        else if (mode == D20Mode.Disadvantage)
            rollResult = Rolls.Min();
        else
            rollResult = Rolls[0];
        
        MyCharacterData.OnValueChanged.Invoke();
    }

    public int Sum => rollResult + MasterBonus + MainStatValue;
    
    public int MasterBonus => global::MasterBonus.Instance.Value;
    
    public int MainStatValue
    {
        get
        {
            switch (mainStat)
            {
                case Stats.сила : mainStatValue = MainStats.Instance.Strength; break;
                case Stats.ловкость : mainStatValue = MainStats.Instance.Dexterity; break;
                case Stats.выносливость : mainStatValue = MainStats.Instance.Strength; break;
                case Stats.интеллект : mainStatValue = MainStats.Instance.Strength; break;
                case Stats.мудрость : mainStatValue = MainStats.Instance.Strength; break;
                case Stats.харизма : mainStatValue = MainStats.Instance.Strength; break;
            }

            return mainStatValue;
        }
    }

    public int RollResult => rollResult;

    public Stats MainStat => mainStat;
}

public enum Stats
{
    сила, ловкость, выносливость, интеллект, мудрость, харизма
}
