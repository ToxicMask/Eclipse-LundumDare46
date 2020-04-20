using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpaceShip : AirSupply
{

    [SerializeField] int minChipNumber = 5;


    private void Start()
    {
        // Equalize if less is present
        if (ShipChip.allInstances.Count < minChipNumber) minChipNumber = ShipChip.allInstances.Count;
    }

    public override void Check(GameObject player)
    {
        //Debug.Log("Checked");

        //Refil Air
        base.Check(player);

        // Check Progress
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
