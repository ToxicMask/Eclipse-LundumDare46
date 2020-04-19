using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompassUI : MonoBehaviour
{
    //transforms Player, Home Rocket

    public Transform playerTransform;
    public Transform rocketHomeTransform;

    public RectTransform compassTransform;


    // Start is called before the first frame update
    void Start()
    {

        // Auto Get
        compassTransform = GetComponent<RectTransform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Return if either are empty
        if (rocketHomeTransform == null || playerTransform == null) return;

        // Get Direction
        Vector2 angleVector = (rocketHomeTransform.position - playerTransform.position).normalized;

        float angle2Rocket =  Mathf.Rad2Deg * (Mathf.Atan2(angleVector.y, angleVector.x));

        float angleCorrect = -90f;

        compassTransform.rotation = Quaternion.Euler(0, 0, angle2Rocket - angleCorrect);

    }

}
