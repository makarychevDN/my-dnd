using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainStatsSaver : BaseSynchronizer
{
    [SerializeField] private MainStats mainStats;

    protected override void Synchronize()
    {
        PlayerPrefs.SetInt("str", mainStats.Strength);
        PlayerPrefs.SetInt("dex", mainStats.Dexterity);
        PlayerPrefs.SetInt("end", mainStats.Endurance);
        PlayerPrefs.SetInt("int", mainStats.Intelligence);
        PlayerPrefs.SetInt("wis", mainStats.Wisdom);
        PlayerPrefs.SetInt("chr", mainStats.Charisma);
    }
}
