using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculatorAbilitiesPanel : BaseSynchronizer
{
    [SerializeField] private CalculatorAbilityButton buttonPrefab;
    [SerializeField] private Transform instancesParent;
    [SerializeField] private List<CalculatorAbilityButton> abilityButtons;
    
    protected override void Synchronize()
    {
        if (abilityButtons.Count == Abilities.Instance.abilities.Count)
            return;

        foreach (var t in abilityButtons)
        {
            Destroy(t.gameObject);
        }

        abilityButtons = new List<CalculatorAbilityButton>();

        for (int i = 0; i < Abilities.Instance.abilities.Count; i++)
        {
            var tempButton = Instantiate(buttonPrefab, instancesParent);
            abilityButtons.Add(tempButton);
            tempButton.Ability = Abilities.Instance.abilities[i];
        }
    }
}
