using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadarUI : MonoBehaviour
{
    // To verify chip distance, and upgrades
    public AstroInv astroInventory;

    // To notify distance
    public Animator radarAnimator;

    public AnimationCurve radarFrequencyCurve;

    public AudioSource audioBlink;

    private void Start()
    {
        // Auto Get
        astroInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<AstroInv>();
        radarAnimator = GetComponent<Animator>();
        audioBlink = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        // Dont execute
        if (astroInventory == null || radarAnimator == null) return;

        // Count 
        if (ShipChip.allInstances.Count > 0)
        {
            float nearestDistance = GetNearestTargetDistance();

            float radarFrequency = radarFrequencyCurve.Evaluate(nearestDistance);


            radarAnimator.SetBool("Detected", (radarFrequency != 0));

            //Set Frequency

            if (radarFrequency != 0) { radarAnimator.speed = radarFrequency; }
            else { radarAnimator.speed = 1; }


            //Debug.Log(radarFrequency);
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

    public void PlayRadarAudio()
    {
        audioBlink.Play();
    }

}
