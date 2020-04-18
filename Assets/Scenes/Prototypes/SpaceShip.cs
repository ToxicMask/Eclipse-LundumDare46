using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour, IPlayerCanCheck
{

    [SerializeField] int minChipNumber = 5;

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
            if (astroInv.currentShipChips >= minChipNumber) PlayerVictory();
            
        }

    }

   protected void PlayerVictory()
    {
        Debug.Log("Victory");
        Application.Quit();
    }

}
