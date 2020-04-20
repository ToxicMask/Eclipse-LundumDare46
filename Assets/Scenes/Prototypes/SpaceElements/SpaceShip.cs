using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour, IPlayerCanCheck
{

    [SerializeField] int minChipNumber = 5;


    private void Start()
    {
        // Equalize if less is present
        if (ShipChip.allInstances.Count < minChipNumber) minChipNumber = ShipChip.allInstances.Count;
    }

    public void Check(GameObject player)
    {
        Debug.Log("Checked");
        CheckPlayerProgress(player);
    }

    public void CheckPlayerProgress(GameObject player)
    {
        // Check for Astro Inventory
        AstroInv astroInv = player.GetComponent<AstroInv>();

        //Check Inv, if not null
        if (astroInv != null)
        {
            // Check Victory
            if (astroInv.GetChipCount()>= minChipNumber) PlayerVictory();
            
        }

    }

   protected void PlayerVictory()
    {
        Debug.LogWarning("Victory");
        Application.Quit();
    }

}
