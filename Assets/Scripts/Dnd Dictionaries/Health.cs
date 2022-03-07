using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : BaseSynchronizer
{
    [SerializeField] private Slider slider;
    [SerializeField] private TMP_Text text;
    
    [SerializeField] private int maxHealth;
    public int MaxHealth
    {
        get => maxHealth;
        set
        {
            maxHealth = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    [SerializeField] private int currentHealth;
    public int CurrentHealth
    {
        get => currentHealth;
        set
        {
            currentHealth = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }

    public void SetHealth(int value) => CurrentHealth = value;
    public void SetHealth(IntProvider provider) => CurrentHealth = provider.TakeValue();

    public void DecreaseHealth(int value) => CurrentHealth -= value;
    public void IncreaseHealth(int value) => CurrentHealth += value;
    
    public void DecreaseHealth(IntProvider provider) => CurrentHealth -= provider.TakeValue();
    public void IncreaseHealth(IntProvider provider) => CurrentHealth += provider.TakeValue();
    

    protected override void Synchronize()
    {
        text.text = currentHealth.ToString();
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
    }
}
