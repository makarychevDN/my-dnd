using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterBonusSaver : BaseSynchronizer
{
    [SerializeField] private MasterBonus masterBonus;

    protected override void Synchronize()
    {
        PlayerPrefs.SetInt("MasterBonus", masterBonus.Value);
    }
}
