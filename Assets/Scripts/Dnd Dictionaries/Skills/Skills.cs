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
        ResetSkillsList();

        if (PlayerPrefs.GetString("Skills") == "")
            return;
        
        var skillStrings = PlayerPrefs.GetString("Skills").Split('~');

        for (int i = 0; i < skillStrings.Length; i++)
        {
            var skillString = skillStrings[i].Split('`');
            GameObject go = new GameObject();
            go.transform.parent = transform;
            Skill skill = go.AddComponent<Skill>();
            skill.Init(skillString[0], Convert.ToInt32(skillString[1]));
            skills.Add(skill);
            go.name = skill.Name;
        }
    }

    public void InitFromFile(List<SkillData> skillsData)
    {
        ResetSkillsList();

        for (int i = 0; i < skillsData.Count; i++)
        {
            GameObject go = new GameObject();
            go.transform.parent = transform;
            Skill skill = go.AddComponent<Skill>();
            skill.Init(skillsData[i].Name, skillsData[i].Value);
            AddSkill(skill);
            go.name = skill.Name;
        }
    }

    private void ResetSkillsList()
    {
        for (int i = 0; i < skills.Count; i++)
        {
            Destroy(skills[i].gameObject);
        }

        skills.Clear();
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
