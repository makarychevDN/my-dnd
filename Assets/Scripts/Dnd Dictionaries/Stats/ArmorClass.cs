using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorClass : MonoBehaviour
{
    public static ArmorClass Instance;

    [SerializeField] private int value;
    public int Value
    {
        get => value;
        set
        {
            this.value = value;
            MyCharacterData.OnValueChanged.Invoke();
        }
    }
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (PlayerPrefs.HasKey("ArmorClass"))
            value = PlayerPrefs.GetInt("ArmorClass");
    }
}
