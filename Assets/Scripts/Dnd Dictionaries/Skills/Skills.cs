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
        
        if(PlayerPrefs.HasKey("Skills"))
            InitFromPlayerPrefs();
    }

    private void InitFromPlayerPrefs()
    {
        for (int i = 0; i < skills.Count; i++)
        {
            Destroy(skills[i].gameObject);
        }
        
        skills.Clear();
        
        if(PlayerPrefs.GetString("Skills") == "")
            return;
        
        var skillStrings = PlayerPrefs.GetString("Skills").Split('~');

        for (int i = 0; i < skillStrings.Length; i++)
        {
            var skillString = skillStrings[i].Split('`');
            Skill skill = Instantiate(new GameObject().AddComponent<Skill>(), transform);
            skill.Init(skillString[0], Convert.ToInt32(skillString[1]));
            skills.Add(skill);
        }
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
