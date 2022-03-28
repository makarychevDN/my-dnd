using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityResourceAdder : MonoBehaviour
{
    [SerializeField] private AbilityResource defaultSkill;
    
    public void Add()
    {
        var newSkill = Instantiate(defaultSkill, AbilityResources.Instance.transform);
        newSkill.name = defaultSkill.Name;
        newSkill.Name = defaultSkill.Name;
        newSkill.Count = defaultSkill.Count;
        newSkill.MaxCount = defaultSkill.MaxCount;
        AbilityResources.Instance.AddAbilityResource(newSkill);    
    }
}
