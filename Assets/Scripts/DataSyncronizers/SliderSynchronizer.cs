using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSynchronizer : BaseSynchronizer
{
    [SerializeField] private Slider slider;
    [SerializeField] private DataKey maxValueKey;
    [SerializeField] private DataKey currentValueKey;

    protected override void Synchronize()
    {
        if (MyCharacterData.Get(maxValueKey) == slider.maxValue && MyCharacterData.Get(currentValueKey) == slider.value)
            return;

        slider.value = MyCharacterData.Get(currentValueKey);
        slider.maxValue = MyCharacterData.Get(maxValueKey);
    }
}
