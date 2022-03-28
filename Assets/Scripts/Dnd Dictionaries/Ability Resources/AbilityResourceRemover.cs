using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityResourceRemover : MonoBehaviour
{
    [SerializeField] private AbilityResourcePanel skillPanel;
    
    public void Remove()
    {
        AbilityResources.Instance.RemoveAbilityResource(skillPanel.AbilityResource);    
    }
}
