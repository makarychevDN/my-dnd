using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AbilityResourcePanel : BaseSynchronizer
{
    [SerializeField] private AbilityResource abilityResource;
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TMP_InputField currentValueInputField;
    [SerializeField] private TMP_InputField maxValueInputField;
    
    public AbilityResource AbilityResource
    {
        get => abilityResource;
        set
        { 
            abilityResource = value;
            Synchronize();
        }
    }
    
    protected override void Synchronize()
    {
        print("daaamn im so synchronized");
        nameInputField.text = abilityResource.Name;
        currentValueInputField.text = abilityResource.Count.ToString();
        maxValueInputField.text = abilityResource.MaxCount.ToString();
    }
    
    public void SetCount(IntProvider provider) => abilityResource.Count = provider.TakeValue();
    
    public void SetMaxCount(IntProvider provider) => abilityResource.MaxCount = provider.TakeValue();
    
    public void SetName(StringProvider provider) => abilityResource.Name = provider.TakeValue();
}