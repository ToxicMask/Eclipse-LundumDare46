using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChipCounterUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textCounter;
    public AstroInv astroInv;

    // Start is called before the first frame update
    void Start()
    {
        // Auto Get
        textCounter = GetComponentInChildren<TextMeshProUGUI>();
        astroInv = GameObject.FindGameObjectWithTag("Player").GetComponent<AstroInv>();
    }

    // Update is called once per frame
    void Update()
    {
        if (astroInv == null || textCounter == null) return;

        textCounter.text = astroInv.currentShipChips.ToString();
    }
}
