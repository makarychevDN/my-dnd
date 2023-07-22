using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public static Abilities Instance;
    [SerializeField] private List<Ability> abilities = new List<Ability>();
    public List<Ability> AbilitiesList 
    { 
        get => abilities;
        
        set
        {
            abilities = value;
            MyCharacterData.OnValueChanged.Invoke();
        } 
    }

    private void Awake()
    {
        Instance = this;
        
        if (PlayerPrefs.HasKey("Abilities"))
            InitFromPlayerPrefs();
    }

    public void InitFromPlayerPrefs()
    {
        ResetAbilitiesList();

        if (PlayerPrefs.GetString("Abilities") == "")
            return;
        
        var abilityStrings = PlayerPrefs.GetString("Abilities").Split('~');

        for (int i = 0; i < abilityStrings.Length; i++)
        {
            var abilityString = abilityStrings[i].Split('`');
            GameObject go = new GameObject();
            go.transform.parent = transform;
            Ability ability = go.AddComponent<Ability>();
            Enum.TryParse(abilityString[1], out DamageType damageType);
            ability.Init(abilityString[0], damageType, Convert.ToInt32(abilityString[2]), Convert.ToInt32(abilityString[3]),Convert.ToInt32(abilityString[4]));
            abilities.Add(ability);
            go.name = ability.AbilityName;
        }

        //MyCharacterData.OnValueChanged.Invoke();
    }

    public void InitFromFile(List<AbilityData> abilitiesData)
    {
        ResetAbilitiesList();

        for (int i = 0; i < abilitiesData.Count; i++)
        {
            var abilityData = abilitiesData[i];
            GameObject go = new GameObject();
            go.transform.parent = transform;
            Ability ability = go.AddComponent<Ability>();
            ability.Init(abilityData.AbilityName, abilityData.DamageType, abilityData.DiceCount, abilityData.DiceValue, abilityData.AdditionDamage);
            abilities.Add(ability);
            go.name = ability.AbilityName;
        }

        MyCharacterData.OnValueChanged.Invoke();
    }

    private void ResetAbilitiesList()
    {
        for (int i = 0; i < abilities.Count; i++)
        {
            Destroy(abilities[i].gameObject);
        }

        abilities.Clear();
    }

    public void AddAbility(Ability skill)
    {
        abilities.Add(skill);
        MyCharacterData.OnValueChanged.Invoke();
    }
    
    public void RemoveAbility(Ability skill)
    {
        if(!abilities.Contains(skill))
            return;
        
        abilities.Remove(skill);
        MyCharacterData.OnValueChanged.Invoke();
    }
}
