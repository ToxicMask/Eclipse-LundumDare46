using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroCheck : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("!");
            // Temp -> Get Collision trough circle
            Collider2D[] collisionArray = Physics2D.OverlapCircleAll(transform.position, 2.5f);

            // Check all collisions
            foreach (Collider2D collider in collisionArray)
            {
                IPlayerCanCheck obj = collider.gameObject.GetComponent<IPlayerCanCheck>();

                if (obj != null) { obj.Check(gameObject);}
            }
        }
    }
}
