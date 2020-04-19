using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Needs Collider
[RequireComponent(typeof(Collider2D))]

public abstract class PickableObject : MonoBehaviour
{
    // If is collision
    protected virtual void OnTriggerEnter2D(Collider2D collision){}
}
