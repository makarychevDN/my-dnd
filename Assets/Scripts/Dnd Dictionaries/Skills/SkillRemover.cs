using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillRemover : MonoBehaviour
{
    [SerializeField] private SkillPanel skillPanel;
    
    public void Remove()
    {
        Skills.Instance.RemoveSkill(skillPanel.Skill);    
    }
}
