using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillAdder : MonoBehaviour
{
    [SerializeField] private Skill defaultSkill;
    
    public void Add()
    {
        var newSkill = Instantiate(defaultSkill, Skills.Instance.transform);
        newSkill.name = defaultSkill.Name;
        newSkill.Name = defaultSkill.Name;
        newSkill.Value = defaultSkill.Value;
        Skills.Instance.AddSkill(newSkill);    
    }
}
