using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityRemover : MonoBehaviour
{
    [SerializeField] private AbilityPanel skillPanel;
    
    public void Remove()
    {
        Abilities.Instance.RemoveAbility(skillPanel.Ability);    
    }
}
