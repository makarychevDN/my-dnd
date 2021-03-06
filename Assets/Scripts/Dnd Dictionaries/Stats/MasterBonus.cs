using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterBonus : MonoBehaviour
{
    public static MasterBonus Instance;

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
        
        if(PlayerPrefs.HasKey("MasterBonus"))
            value = PlayerPrefs.GetInt("MasterBonus");
    }
}
