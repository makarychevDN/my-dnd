using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    [SerializeField] private List<Stat> inputStats;
    public Dictionary<Key, int> stats;

    private void Awake()
    {
        stats = new Dictionary<Key, int>();
        inputStats.ForEach(inputStat => stats.Add(inputStat.key, inputStat.value));
    }
}

[Serializable]
struct Stat
{
    public Key key;
    public int value;
}
