using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class IntCharacterDataUpdater : CharacterDataUpdater<IntProvider>
{
    [SerializeField] private DataKey key;
    
    public void Set() => MyCharacterData.Set(key, provider.TakeValue());

    public void Increase() => MyCharacterData.Increase(key, provider.TakeValue());

    public void Decrease() => MyCharacterData.Decrease(key, provider.TakeValue());
}
