using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarUI : MonoBehaviour
{
    // To verify chip distance, and upgrades
    public AstroInv astroInventory;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (astroInventory == null) return;

        // Count 
        if (ShipChip.allInstances.Count > 0)
        {
            float nearestDistance = GetNearestTargetDistance();

            Debug.Log(nearestDistance);
        } 
        else
        {
            Debug.Log("Done");
            Destroy(gameObject);
        }
    }

    float GetNearestTargetDistance()
    { 

        float nearestDistance = float.MaxValue;


        foreach (ShipChip chip in ShipChip.allInstances)
        {
            Vector3 astroPosition = astroInventory.transform.position;

            Vector3 newTarget = chip.transform.position;

            float newDistance = (newTarget - astroPosition).magnitude;

            // Set new if smaller
            if (newDistance < nearestDistance) { nearestDistance = newDistance; }
        }


        return nearestDistance;
    }

}
