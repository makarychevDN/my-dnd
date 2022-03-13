using TMPro;
using UnityEngine;

public class SkillPanel : BaseSynchronizer
{
    [SerializeField] private Skill skill;
    [SerializeField] private TMP_InputField valueInputField;
    [SerializeField] private TMP_InputField nameInputField;


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
        valueInputField.text = skill.Value.ToString();
        nameInputField.text = skill.Name;
    }

    public void SetValue(IntProvider provider) => skill.Value = provider.TakeValue();
    
    public void SetName(StringProvider provider) => skill.Name = provider.TakeValue();
}
