using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveInfoInFileManager : MonoBehaviour
{
    [SerializeField] private Health health;
    [SerializeField] private ArmorClass armorClass;
    [SerializeField] private MasterBonus masterBonus;
    [SerializeField] private MainStats mainStats;
    [SerializeField] private Abilities abilities;
    [SerializeField] private StringProvider fileNameProvider;

    [ContextMenu("Save")]
    public void Save()
    {
        CharacterData characterData = new CharacterData();

        characterData.MaxHealth = health.MaxHealth;
        characterData.CurrentHealth = health.CurrentHealth;
        characterData.ArmorClass = armorClass.Value;
        characterData.MasterBonus = masterBonus.Value;

        characterData.Strength = mainStats.Strength;
        characterData.Dexterity = mainStats.Dexterity;
        characterData.Endurance = mainStats.Endurance;
        characterData.Intelligence = mainStats.Intelligence;
        characterData.Wisdom = mainStats.Wisdom;
        characterData.Charisma = mainStats.Charisma;

        characterData.MoneyData = new MoneyData();
        characterData.MoneyData.Gold = Money.Instance.GetCount(MoneyType.Gold);
        characterData.MoneyData.Silver = Money.Instance.GetCount(MoneyType.Silver);
        characterData.MoneyData.Copper = Money.Instance.GetCount(MoneyType.Copper);

        characterData.Abilities = new List<AbilityData>();
        for(int i = 0; i < Abilities.Instance.AbilitiesList.Count; i++)
        {
            var abilityData = new AbilityData();
            abilityData.AbilityName = Abilities.Instance.AbilitiesList[i].AbilityName;
            abilityData.DiceCount = Abilities.Instance.AbilitiesList[i].DiceCount;
            abilityData.DiceValue = Abilities.Instance.AbilitiesList[i].DiceValue;
            abilityData.AdditionDamage = Abilities.Instance.AbilitiesList[i].AdditionDamage;
            abilityData.DamageType = Abilities.Instance.AbilitiesList[i].DamageType;
            characterData.Abilities.Add(abilityData);
        }

        characterData.AbilityResources = new List<AbilityResourceData>();
        for (int i = 0; i < AbilityResources.Instance.abilityResources.Count; i++)
        {
            var abilityResource = new AbilityResourceData();
            abilityResource.Name = AbilityResources.Instance.abilityResources[i].Name;
            abilityResource.CurrentCount = AbilityResources.Instance.abilityResources[i].Count;
            abilityResource.MaxCount = AbilityResources.Instance.abilityResources[i].MaxCount;
            characterData.AbilityResources.Add(abilityResource);
        }

        characterData.SkillsData = new List<SkillData>();
        for (int i = 0; i < Skills.Instance.skills.Count; i++)
        {
            var skill = new SkillData();
            skill.Name = Skills.Instance.skills[i].Name;
            skill.Value = Skills.Instance.skills[i].Value;
            characterData.SkillsData.Add(skill);
        }

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream savedFile = File.Create($"{Application.dataPath}/{fileNameProvider.TakeValue()}.bin");
        formatter.Serialize( savedFile, characterData);
        savedFile.Close();
    }

    [ContextMenu("Load")]
    public void Load()
    {
        if (!File.Exists($"{Application.dataPath}/{fileNameProvider.TakeValue()}.bin"))
            return;

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream savedFile = File.Open($"{Application.dataPath}/{fileNameProvider.TakeValue()}.bin", FileMode.Open);

        CharacterData characterData = (CharacterData)formatter.Deserialize(savedFile);

        health.MaxHealth = characterData.MaxHealth;
        health.CurrentHealth = characterData.CurrentHealth;
        armorClass.Value = characterData.ArmorClass;
        masterBonus.Value = characterData.MasterBonus;

        mainStats.Strength = characterData.Strength;
        mainStats.Dexterity = characterData.Dexterity;
        mainStats.Endurance = characterData.Endurance;
        mainStats.Intelligence = characterData.Intelligence;
        mainStats.Wisdom = characterData.Wisdom;
        mainStats.Charisma = characterData.Charisma;

        Money.Instance.SetCount(MoneyType.Gold, characterData.MoneyData.Gold);
        Money.Instance.SetCount(MoneyType.Silver, characterData.MoneyData.Silver);
        Money.Instance.SetCount(MoneyType.Copper, characterData.MoneyData.Copper);

        Abilities.Instance.InitFromFile(characterData.Abilities);
        AbilityResources.Instance.InitFromFile(characterData.AbilityResources);
        Skills.Instance.InitFromFile(characterData.SkillsData);

        savedFile.Close();
    }
}

[Serializable]
public class CharacterData
{
    public int MaxHealth;
    public int CurrentHealth;
    public int ArmorClass;
    public int MasterBonus;

    public int Strength;
    public int Dexterity;
    public int Endurance;
    public int Intelligence;
    public int Wisdom;
    public int Charisma;

    public MoneyData MoneyData;
    public List<AbilityData> Abilities;
    public List<AbilityResourceData> AbilityResources;
    public List<SkillData> SkillsData;
}

[Serializable]
public class AbilityData
{
    public string AbilityName;
    public int DiceCount;
    public int DiceValue;
    public int AdditionDamage;
    public DamageType DamageType;
}

[Serializable]
public class AbilityResourceData
{
    public string Name;
    public int CurrentCount;
    public int MaxCount;
}

[Serializable]
public class MoneyData
{
    public int Gold;
    public int Silver;
    public int Copper;
}

[Serializable]
public class SkillData
{
    public string Name;
    public int Value;
}
