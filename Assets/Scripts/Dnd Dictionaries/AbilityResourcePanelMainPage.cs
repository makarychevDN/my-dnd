using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilityResourcePanelMainPage : BaseSynchronizer
{
    [SerializeField] private AbilityResource abilityResource;
    [SerializeField] private TMP_Text nameTextField;
    [SerializeField] private TMP_Text countTextField;
    [SerializeField] private Slider slider;

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
        nameTextField.text = abilityResource.Name;
        countTextField.text = abilityResource.Count.ToString();
        slider.maxValue = abilityResource.MaxCount;
        slider.value = abilityResource.Count;
    }
    
    public void SetCount(IntProvider provider) => abilityResource.Count = provider.TakeValue();
    
    public void IncreaseCount(IntProvider provider) => abilityResource.Count += provider.TakeValue();
    
    public void DecreaseCount(IntProvider provider) => abilityResource.Count -= provider.TakeValue();
}
