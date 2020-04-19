using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroController : MonoBehaviour
{
    // Astro Components
    AstroAnim astroAnim;
    AstroCheck astroCheck;
    AstroMove astroMove;
    AstroInv astroInv;

    // Start is called before the first frame update
    void Start()
    {
        // Auto Get
        astroAnim = GetComponent<AstroAnim>();
        astroCheck = GetComponent<AstroCheck>(); ;
        astroMove = GetComponent<AstroMove>(); ;
        astroInv = GetComponent<AstroInv>(); ;

    }

    // Update is called once per frame
    void Update()
    {
        // Get Move Input
        Vector2 inputVector = (new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))).normalized;

        // Set Move Input
        astroMove.inputVector = inputVector;

        // Set Move Anim parameters
        if (inputVector != Vector2.zero)
        {
            astroAnim.vectorFront = inputVector;
        }

        // Check Action
        if (Input.GetButtonDown("Fire1"))
        {
            astroCheck.CheckSurronding();
        }

        // Update Anim Control
        astroAnim.UpdateMoveAnimation();
    }
}
