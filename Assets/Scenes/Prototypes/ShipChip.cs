using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipChip : PickableObject
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        // Ends if is not Player
        if (!collision.gameObject.CompareTag("Player")) return;

        // Searches for inventory
        AstroInv astroInv = collision.gameObject.GetComponent<AstroInv>();

        // Picks if is not null
        if (astroInv != null) {
            // Put in inventory
            astroInv.currentShipChips++;

            // Ends Chip
            Destroy(gameObject);
        }

    }
}
