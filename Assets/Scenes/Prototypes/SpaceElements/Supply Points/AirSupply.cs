using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collision2D))]
public abstract class AirSupply : MonoBehaviour, IPlayerCanCheck
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public virtual void Check(GameObject player)
    {

        Debug.Log("Refil O2");

        AstroHealth airHealth = player.GetComponent<AstroHealth>();

        // Fill Air
        airHealth.RestoreAir();
    }

    
}
