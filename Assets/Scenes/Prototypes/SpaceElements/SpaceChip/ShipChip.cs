using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShipChip : PickableObject
{

    public static float airIncrease = 20;

    public static List<ShipChip> allInstances = new List<ShipChip>();

    private void Awake()
    {
        // Add instance
        allInstances.Add(this);
    }

    private void OnDestroy()
    {
        allInstances.Remove(this);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        // Ends if is not Player
        if (!collision.gameObject.CompareTag("Player")) return;

        // Searches for inventory / Air Health
        AstroInv astroInv = collision.gameObject.GetComponent<AstroInv>();
        AstroHealth astroAir = collision.gameObject.GetComponent<AstroHealth>();

        // Picks if is not null
        if (astroInv != null)
        {
            // Put in inventory
            astroInv.AddChip();
        }

        if (astroAir != null)
        {
            // Increase Max By
            astroAir.IncreaseMaxAir(airIncrease);

            // Increase Air Upgrade
            airIncrease += 10;
        }

        // Ends Chip
        Destroy(gameObject);
    }
}
