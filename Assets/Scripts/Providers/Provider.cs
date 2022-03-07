using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Provider<T> : MonoBehaviour
{
    public abstract T TakeValue();
}
