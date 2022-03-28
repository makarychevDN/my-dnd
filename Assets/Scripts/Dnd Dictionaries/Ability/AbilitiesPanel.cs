using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilitiesPanel : BaseSynchronizer
{
    [SerializeField] private Transform instancesParent;
    [SerializeField] private AbilityPanel panelPrefab;
    [SerializeField] private List<AbilityPanel> abilityPanels;

    protected override void Synchronize()
    {
        if (abilityPanels.Count == Abilities.Instance.abilities.Count)
            return;

        foreach (var t in abilityPanels)
        {
            Destroy(t.gameObject);
        }

        abilityPanels = new List<AbilityPanel>();

        for (int i = 0; i < Abilities.Instance.abilities.Count; i++)
        {
            var tempPanel = Instantiate(panelPrefab, instancesParent);
            abilityPanels.Add(tempPanel);
            tempPanel.Ability = Abilities.Instance.abilities[i];
        }
    }
}