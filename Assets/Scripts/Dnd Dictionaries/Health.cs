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
            currentHealth = value;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
}
