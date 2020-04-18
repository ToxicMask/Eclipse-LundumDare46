using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]

public class AstroChar : MonoBehaviour
{
    // Components
    [SerializeField] Rigidbody2D rb2D;

    // Physycs Variables
    [SerializeField] Vector2 linearVelocity;
    [SerializeField] bool debugMode = false;

    float floatAccel = 4;
    float floatDamp = 1;

    float maxSpeed = 96;
    float minSpeed = 4;

    // Input Variables
    Vector2 inputVector;


    private void Start()
    { 
        // Auto get
        rb2D = GetComponent<Rigidbody2D>();

        // Reset Var
        linearVelocity = Vector2.zero;

        inputVector = Vector2.zero;
    }

    // Update is called once per frame
    private void Update()
    {
        // Get Input
        inputVector = (new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))).normalized ;
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
