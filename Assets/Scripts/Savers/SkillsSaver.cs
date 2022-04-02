using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class SkillsSaver : BaseSynchronizer
{
    [SerializeField] private Skills skills;
        
    protected override void Synchronize()
    {
        PlayerPrefs.SetString("Skills", SkillsToString());
    }

    private string SkillsToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var skill in skills.skills)
        {
            sb.Append($"{skill.Name}`{skill.Value}~");
        }
        
        if(sb.Length != 0)
            sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}
