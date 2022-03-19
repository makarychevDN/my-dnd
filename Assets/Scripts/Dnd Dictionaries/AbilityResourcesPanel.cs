using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityResourcesPanel : BaseSynchronizer
{
    [SerializeField] private Transform instancesParent;
    [SerializeField] private AbilityResourcePanel panelPrefab;
    [SerializeField] private List<AbilityResourcePanel> abilityResourcePanels;
    [SerializeField] private Transform addButtonPanel;
    
    protected override void Synchronize()
    {
        if(abilityResourcePanels.Count == AbilityResources.Instance.abilityResources.Count)
            return;
        
        foreach (var t in abilityResourcePanels)
        {
            Destroy(t.gameObject);
        }

        abilityResourcePanels = new List<AbilityResourcePanel>();
        
        for (int i = 0; i < AbilityResources.Instance.abilityResources.Count; i++)
        {
            var tempPanel = Instantiate(panelPrefab, instancesParent);
            abilityResourcePanels.Add(tempPanel);
            tempPanel.AbilityResource = AbilityResources.Instance.abilityResources[i];
        }
        
        addButtonPanel.SetAsLastSibling();
    }
}
