using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirSupplyUI : MonoBehaviour
{

    public Slider airSlider;
    public Image fill;
    public Gradient gradient;

    private void Start()
    {
        // Auto Get
        airSlider = GetComponent<Slider>();
        if (fill == null) { Debug.LogWarning("No filling reference."); }
    }

    public void SetMaxAir(float newMax)
    {
        airSlider.maxValue = newMax;
        airSlider.value = newMax;

        // Set Color
        if (fill != null) { fill.color = gradient.Evaluate(1f); }

        // Set Size
        airSlider.GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, newMax);
    }

    public void SetAir (float newValue)
    {
        airSlider.value = newValue;

        if (fill != null){ fill.color = gradient.Evaluate(airSlider.normalizedValue); }
    }

    private void SetSliderSize()
    {
        //airSlider.transform;
    }
}
