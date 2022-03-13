using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MyCharacterData : MonoBehaviour
{
    public static UnityEvent OnValueChanged = new();
    public static MyCharacterData Instance;
}
