using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class AstroMove : MonoBehaviour
{
    // Components
    [SerializeField] Rigidbody2D rb2D;

    // Physycs Variables
    [SerializeField] Vector2 linearVelocity;
    [SerializeField] bool debugMode = false;

    float floatAccel = 4;
    float floatDamp = 0.4f;

    float maxSpeed = 128;
    float minSpeed = 4;

    // Input Variables
    public Vector2 inputVector;


    private void Start()
    { 
        // Auto get
        rb2D = GetComponent<Rigidbody2D>();

        // Reset Variables
        linearVelocity = Vector2.zero;

        inputVector = Vector2.zero;
    }

    private void FixedUpdate()
    {
        // Standard Movement
        FloatMovement();
    }

    void FloatMovement()
    {

        // Accel
        if (inputVector != Vector2.zero)
        {
            // Debug Mode
            if (debugMode) Debug.Log("Accel");

            // Set Speed to truster
            linearVelocity += (inputVector * floatAccel);
            
            // Clamp max speed
            linearVelocity = Vector2.ClampMagnitude(linearVelocity, maxSpeed);
        }

        // Damp
        else if (linearVelocity.magnitude > minSpeed)
        {
            // Debug Mode
            if (debugMode) Debug.Log("Damp");

            // Set Dump
            linearVelocity -= (linearVelocity.normalized * floatDamp);
        }

        // Full Stop
        else if (linearVelocity != Vector2.zero)
        {
            // Debug Mode
            if (debugMode) Debug.Log("FullStop");

            // Full Stop
            linearVelocity = Vector2.zero;
        }

        // Update Rigid Body
        rb2D.velocity = linearVelocity * Time.fixedDeltaTime;

    }
}
