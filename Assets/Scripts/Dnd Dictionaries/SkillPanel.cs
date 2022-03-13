using TMPro;
using UnityEngine;

public class SkillPanel : BaseSynchronizer
{
    [SerializeField] private Skill skill;
    [SerializeField] private TMP_InputField valueInputField;
    [SerializeField] private TMP_InputField nameInputField;
    [SerializeField] private TMP_Text nameLabel;


    public Skill Skill
    {
        get => skill;
        set
        { 
            skill = value;
            Synchronize();
        }
    }

    protected override void Synchronize()
    {
        valueInputField.text = skill.value.ToString();
        nameInputField.text = skill.name;
        nameLabel.text = skill.name;
    }
}
