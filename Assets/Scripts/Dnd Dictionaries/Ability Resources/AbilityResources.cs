using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityResources : MonoBehaviour
{
    public static AbilityResources Instance;
    public List<AbilityResource> abilityResources;

    private void Awake()
    {
        Instance = this;
        
        if(PlayerPrefs.HasKey("AbilityResources"))
            InitFromPlayerPrefs();
    }

    private void InitFromPlayerPrefs()
    {
        for (int i = 0; i < abilityResources.Count; i++)
        {
            Destroy(abilityResources[i].gameObject);
        }
        
        abilityResources.Clear();
        
        if(PlayerPrefs.GetString("AbilityResources") == "")
            return;
        
        var abilityResourceStrings = PlayerPrefs.GetString("AbilityResources").Split('~');

        for (int i = 0; i < abilityResourceStrings.Length; i++)
        {
            var abilityResourceString = abilityResourceStrings[i].Split('`');
            GameObject go = new GameObject();
            go.transform.parent = transform;
            AbilityResource abilityResource = go.AddComponent<AbilityResource>();
            abilityResource.Init(abilityResourceString[0], Convert.ToInt32(abilityResourceString[1]), Convert.ToInt32(abilityResourceString[2]));
            abilityResources.Add(abilityResource);
            go.name = abilityResource.Name;
        }
    }

    public void AddAbilityResource(AbilityResource abilityResource)
    {
        abilityResources.Add(abilityResource);
        MyCharacterData.OnValueChanged.Invoke();
    }
    
    public void RemoveAbilityResource(AbilityResource abilityResource)
    {
        if(!abilityResources.Contains(abilityResource))
            return;
        
        abilityResources.Remove(abilityResource);
        MyCharacterData.OnValueChanged.Invoke();
    }
}
