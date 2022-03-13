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
        for (int i = 0; i < skillPanels.Count; i++)
        {
            Destroy(skillPanels[i].gameObject);
        }

        skillPanels = new List<SkillPanel>();
        
        for (int i = 0; i < Skills.Instance.skills.Count; i++)
        {
            print(1);
            var tempPanel = Instantiate(panelPrefab, instancesParent);
            print(2);
            skillPanels.Add(tempPanel);
            print(3);
            tempPanel.Skill = Skills.Instance.skills[i];
            print(4);
        }
        
        addButtonPanel.SetAsLastSibling();
    }
}
