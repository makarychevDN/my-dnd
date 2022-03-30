using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HitSuccessPanel : BaseSynchronizer
{
    [SerializeField] private TMP_Text hitSuccessSumLabel;
    [SerializeField] private TMP_Text hitSuccessDetailedLabel;
    
    protected override void Synchronize()
    {
        hitSuccessSumLabel.text = HitSuccessCalculator.Instance.Sum.ToString();
        hitSuccessDetailedLabel.text =
            $"дайс {HitSuccessCalculator.Instance.RollResult}\n{HitSuccessCalculator.Instance.MainStat.ToString()} {HitSuccessCalculator.Instance.MainStatValue}\nбма {HitSuccessCalculator.Instance.MasterBonus}";
    }
}
