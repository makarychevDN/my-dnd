using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValueIntProvider : IntProvider
{
    [SerializeField] private Slider slider;
    public override int TakeValue() => (int) slider.value;
}
