using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChipCounterUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textCounter;

    // Start is called before the first frame update
    void Start()
    {
        // Auto Get
        textCounter = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateChipValue(int newValue)
    {
        if (textCounter == null) return;

        textCounter.text = newValue.ToString();
    }
}
