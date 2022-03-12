using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HitsAndSomeShitPanel : BaseSynchronizer
{
    [SerializeField] private TMP_InputField currentHealth;
    [SerializeField] private TMP_InputField maxHealth;
    [SerializeField] private TMP_InputField armorClass;
    [SerializeField] private TMP_InputField masterBonus;

    protected override void Synchronize()
    {
        currentHealth.text = Health.Instance.CurrentHealth.ToString();
        maxHealth.text = Health.Instance.MaxHealth.ToString();
    }
    
    public void SetCurrentHealth(int value) => Health.Instance.CurrentHealth = value;
    public void SetCurrentHealth(IntProvider provider) => Health.Instance.CurrentHealth = provider.TakeValue();
    
    public void SetMaxHealth(int value) => Health.Instance.MaxHealth = value;
    public void SetMaxHealth(IntProvider provider) => Health.Instance.MaxHealth = provider.TakeValue();
    
}
