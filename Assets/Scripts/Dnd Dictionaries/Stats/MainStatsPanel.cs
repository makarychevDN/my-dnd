using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainStatsPanel : BaseSynchronizer
{
    [SerializeField] private TMP_InputField strength;
    [SerializeField] private TMP_InputField dexterity;
    [SerializeField] private TMP_InputField endurance;
    [SerializeField] private TMP_InputField intelligence;
    [SerializeField] private TMP_InputField wisdom;
    [SerializeField] private TMP_InputField charisma;
    
    [Space]
    
    [SerializeField] private TMP_InputField strengthMod;
    [SerializeField] private TMP_InputField dexterityMod;
    [SerializeField] private TMP_InputField enduranceMod;
    [SerializeField] private TMP_InputField intelligenceMod;
    [SerializeField] private TMP_InputField wisdomMod;
    [SerializeField] private TMP_InputField charismaMod;
    
    protected override void Synchronize()
    {
        strength.text = MainStats.Instance.Strength.ToString();
        dexterity.text = MainStats.Instance.Dexterity.ToString();
        endurance.text = MainStats.Instance.Endurance.ToString();
        intelligence.text = MainStats.Instance.Intelligence.ToString();
        wisdom.text = MainStats.Instance.Wisdom.ToString();
        charisma.text = MainStats.Instance.Charisma.ToString();
        
        strengthMod.text = MainStats.Instance.StrengthMod.ToString();
        dexterityMod.text = MainStats.Instance.DexterityMod.ToString();
        enduranceMod.text = MainStats.Instance.EnduranceMod.ToString();
        intelligenceMod.text = MainStats.Instance.IntelligenceMod.ToString();
        wisdomMod.text = MainStats.Instance.WisdomMod.ToString();
        charismaMod.text = MainStats.Instance.CharismaMod.ToString();
    }
    
    public void SetStrength(IntProvider provider) => MainStats.Instance.Strength = provider.TakeValue();
    public void SetDexterity(IntProvider provider) => MainStats.Instance.Dexterity = provider.TakeValue();
    public void SetEndurance(IntProvider provider) => MainStats.Instance.Endurance = provider.TakeValue();
    public void SetIntelligence(IntProvider provider) => MainStats.Instance.Intelligence = provider.TakeValue();
    public void SetWisdom(IntProvider provider) => MainStats.Instance.Wisdom = provider.TakeValue();
    public void SetCharisma(IntProvider provider) => MainStats.Instance.Charisma = provider.TakeValue();
}
