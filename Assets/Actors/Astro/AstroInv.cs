using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroInv : MonoBehaviour
{
    [SerializeField] int currentShipChips = 0;

    public ChipCounterUI counterUI;

    private void Start()
    {
        // Auto Get
        counterUI = GameObject.FindGameObjectWithTag("PlayerUI").GetComponentInChildren<ChipCounterUI>();
    }

    public void AddChip()
    {
        currentShipChips++;

        counterUI.UpdateChipValue(currentShipChips);
    }

    public int GetChipCount()
    {
        return currentShipChips;
    }
}
