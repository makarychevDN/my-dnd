using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSaver : BaseSynchronizer
{
    [SerializeField] private Health health;
    
    protected override void Synchronize()
    {
        PlayerPrefs.SetInt("CurrentHealth", health.CurrentHealth);
        PlayerPrefs.SetInt("MaxHealth", health.MaxHealth);
    }
}
