using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSyncronizer : BaseSynchronizer
{
    [SerializeField] private DataKey dataKey;
    [SerializeField] private TMP_Text text;
    
    protected override void Synchronize()
    {
        if (MyCharacterData.Get(dataKey).ToString() == text.text)
            return;

        text.text = MyCharacterData.Get(dataKey).ToString();
    }
}
