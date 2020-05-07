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

        GameObject playerUI = GameObject.FindGameObjectWithTag("PlayerUI");

        counterUI =  (playerUI != null) ? playerUI.GetComponentInChildren<ChipCounterUI>() : null;
    }

    public void AddChip()
    {
        currentShipChips++;

        if (counterUI != null) counterUI.UpdateChipValue(currentShipChips);
    }

    public int GetChipCount()
    {
        return currentShipChips;
    }
}
