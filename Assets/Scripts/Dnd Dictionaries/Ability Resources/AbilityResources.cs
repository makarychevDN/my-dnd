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
