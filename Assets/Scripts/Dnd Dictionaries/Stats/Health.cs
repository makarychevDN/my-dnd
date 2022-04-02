using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static Health Instance;

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
            int hashedValue = currentHealth;
            currentHealth = value;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
            
            if (currentHealth < hashedValue)
            {
                Journal.Instance.AddDataInstance($"получено {hashedValue - currentHealth} урона ({hashedValue} => {currentHealth})");
            }

            if (currentHealth > hashedValue)
            {
                Journal.Instance.AddDataInstance($"восстановлено {currentHealth - hashedValue} здоровья ({hashedValue} => {currentHealth})");
            }
            
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        
        if(!(PlayerPrefs.HasKey("MaxHealth") && PlayerPrefs.HasKey("CurrentHealth")))
            return;

        maxHealth = PlayerPrefs.GetInt("MaxHealth");
        currentHealth = PlayerPrefs.GetInt("CurrentHealth");
    }
}
