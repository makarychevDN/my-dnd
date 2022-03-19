using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsPanel : BaseSynchronizer
{
    [SerializeField] private Transform instancesParent;
    [SerializeField] private SkillPanel panelPrefab;
    [SerializeField] private List<SkillPanel> skillPanels;
    [SerializeField] private Transform addButtonPanel;
    
    protected override void Synchronize()
    {
        if(skillPanels.Count == Skills.Instance.skills.Count)
            return;
        
        foreach (var t in skillPanels)
        {
            Destroy(t.gameObject);
        }

        skillPanels = new List<SkillPanel>();
        
        for (int i = 0; i < Skills.Instance.skills.Count; i++)
        {
            var tempPanel = Instantiate(panelPrefab, instancesParent);
            skillPanels.Add(tempPanel);
            tempPanel.Skill = Skills.Instance.skills[i];
        }
        
        addButtonPanel.SetAsLastSibling();
    }
}
