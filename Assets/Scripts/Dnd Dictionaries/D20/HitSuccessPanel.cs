using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HitSuccessPanel : BaseSynchronizer
{
    [SerializeField] private TMP_Text hitSuccessSumLabel;
    [SerializeField] private TMP_Text hitSuccessDetailedLabel;
    [SerializeField] private TMP_Dropdown modificatorDropdown;
    
    protected override void Synchronize()
    {
        modificatorDropdown.value = (int)HitSuccessCalculator.Instance.MainStat;
        
        hitSuccessDetailedLabel.text =
            $"дайс {HitSuccessCalculator.Instance.RollResult}\n{HitSuccessCalculator.Instance.MainStat.ToString()} {HitSuccessCalculator.Instance.MainStatValue}\nбма {HitSuccessCalculator.Instance.MasterBonus}";

        if (HitSuccessCalculator.Instance.RollResult == 1)
        {
            hitSuccessSumLabel.text = "чистая 1";
        }
        else if(HitSuccessCalculator.Instance.RollResult == 20)
        {
            hitSuccessSumLabel.text = "чистая 20";
        }
        else
        {
            hitSuccessSumLabel.text = HitSuccessCalculator.Instance.Sum.ToString();
        }
    }
}
