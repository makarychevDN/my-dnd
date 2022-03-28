using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityResourcePanelsMainPage : BaseSynchronizer
{
    [SerializeField] private Transform instancesParent;
    [SerializeField] private AbilityResourcePanelMainPage panelPrefab;
    [SerializeField] private List<AbilityResourcePanelMainPage> abilityResourcePanels;

    protected override void Synchronize()
    {
        if(abilityResourcePanels.Count == AbilityResources.Instance.abilityResources.Count)
            return;
        
        foreach (var t in abilityResourcePanels)
        {
            Destroy(t.gameObject);
        }

        abilityResourcePanels = new List<AbilityResourcePanelMainPage>();
        
        for (int i = 0; i < AbilityResources.Instance.abilityResources.Count; i++)
        {
            var tempPanel = Instantiate(panelPrefab, instancesParent);
            abilityResourcePanels.Add(tempPanel);
            tempPanel.AbilityResource = AbilityResources.Instance.abilityResources[i];
        }
    }
}
