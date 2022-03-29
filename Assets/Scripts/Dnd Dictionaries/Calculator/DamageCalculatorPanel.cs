using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class DamageCalculatorPanel : BaseSynchronizer
{
    [SerializeField] private TMP_Text damageSumLabel;
    [SerializeField] private TMP_Text sortedDamageLabel;
    [SerializeField] private TMP_Text detailedSortedDamageLabel;
    
    protected override void Synchronize()
    {
        DamageSortedByTypesOutput();
        DetailedDamageSortedByTypesOutput();
        damageSumLabel.text = DamageCalculator.Instance.Sum.ToString();
    }

    private void DamageSortedByTypesOutput()
    {
        StringBuilder sb = new StringBuilder();
        var damage = DamageCalculator.Instance.SumsOfDamageSortedByType();

        foreach (var damageInstance in damage)
        {
            sb.Append(damageInstance.Key).Append(" ").Append(damageInstance.Value).Append("\n");
        }

        sortedDamageLabel.text = sb.ToString();
    }
    
    private void DetailedDamageSortedByTypesOutput()
    {
        StringBuilder sb = new StringBuilder();
        var damage = DamageCalculator.Instance.SumsOfDetailedDamageSortedByType();

        foreach (var damageInstance in damage)
        {
            sb.Append(damageInstance.Key).Append(" ");
            int sumOfDamageSortedByType = 0;
            
            foreach (var damageUnit in damageInstance.Value)
            {
                sb.Append(damageUnit).Append(" ");
                sumOfDamageSortedByType += damageUnit;
            }

            sb.Append("(").Append(sumOfDamageSortedByType).Append(")").Append("\n");
        }

        detailedSortedDamageLabel.text = sb.ToString();
    }
}
