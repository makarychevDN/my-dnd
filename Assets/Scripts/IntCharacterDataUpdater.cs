using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class IntCharacterDataUpdater : CharacterDataUpdater<IntProvider>
{
    [SerializeField] private Key key;

    public void Set()
    {
    }

    public void Increase()
    {
        //MyCharacterData.Increase(key, provider.TakeValue());
    }

    public void Decrease()
    {
        //MyCharacterData.Decrease(key, provider.TakeValue());
    }
}
