using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    public static Abilities Instance;
    public List<Ability> abilities;

    private void Awake()
    {
        Instance = this;
    }

    public void AddAbility(Ability skill)
    {
        abilities.Add(skill);
        MyCharacterData.OnValueChanged.Invoke();
    }
    
    public void RemoveAbility(Ability skill)
    {
        if(!abilities.Contains(skill))
            return;
        
        abilities.Remove(skill);
        MyCharacterData.OnValueChanged.Invoke();
    }
}
