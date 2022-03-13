using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public static Skills Instance;
    public List<Skill> skills;

    private void Awake()
    {
        Instance = this;
        //MyCharacterData.OnValueChanged.Invoke();
    }

    public void AddSkill(Skill skill)
    {
        skills.Add(skill);
        MyCharacterData.OnValueChanged.Invoke();
    }
    
    public void RemoveSkill(Skill skill)
    {
        if(!skills.Contains(skill))
            return;
        
        skills.Remove(skill);
        MyCharacterData.OnValueChanged.Invoke();
    }
}
