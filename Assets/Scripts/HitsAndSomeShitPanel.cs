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
        armorClass.text = ArmorClass.Instance.Value.ToString();
        masterBonus.text = MasterBonus.Instance.Value.ToString();
    }
    
    public void SetCurrentHealth(IntProvider provider) => Health.Instance.CurrentHealth = provider.TakeValue();
    
    public void SetMaxHealth(IntProvider provider) => Health.Instance.MaxHealth = provider.TakeValue();
    
    public void SetArmorClass(IntProvider provider) => ArmorClass.Instance.Value = provider.TakeValue();
    
    public void SetMasterBonus(IntProvider provider) => MasterBonus.Instance.Value = provider.TakeValue();
    
}
