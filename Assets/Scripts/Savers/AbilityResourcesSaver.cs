using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class AbilityResourcesSaver : BaseSynchronizer
{
    [SerializeField] private AbilityResources abilityResources;
        
    protected override void Synchronize()
    {
        PlayerPrefs.SetString("AbilityResources", AbilityResourcesToString());
    }

    private string AbilityResourcesToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var abilityResource in abilityResources.abilityResources)
        {
            sb.Append($"{abilityResource.Name}`{abilityResource.MaxCount}`{abilityResource.Count}~");
        }
        
        if(sb.Length != 0)
            sb.Remove(sb.Length - 1, 1);

        print(sb.ToString());
        return sb.ToString();
    }
}
