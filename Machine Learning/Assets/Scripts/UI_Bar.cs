using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Bar : MonoBehaviour
{
    public Slider slider;

    public void SetMax(float val)
    {
        slider.maxValue = val;
        slider.value = val;
    }
    
    public void SetVal(float val)
    {
        slider.value = val;
    }
}
