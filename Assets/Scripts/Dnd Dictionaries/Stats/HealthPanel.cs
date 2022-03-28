using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthPanel : BaseSynchronizer
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text text;

    protected override void Synchronize()
    {
        text.text = Health.Instance.CurrentHealth.ToString();
        slider.maxValue = Health.Instance.MaxHealth;
        slider.value = Health.Instance.CurrentHealth;
    }
    
    public void SetCurrentHealth(int value) => Health.Instance.CurrentHealth = value;
    public void SetCurrentHealth(IntProvider provider) => Health.Instance.CurrentHealth = provider.TakeValue();

    public void DecreaseHealth(int value) => Health.Instance.CurrentHealth -= value;
    public void IncreaseHealth(int value) => Health.Instance.CurrentHealth += value;
    
    public void DecreaseHealth(IntProvider provider) => Health.Instance.CurrentHealth -= provider.TakeValue();
    public void IncreaseHealth(IntProvider provider) => Health.Instance.CurrentHealth += provider.TakeValue();
}
