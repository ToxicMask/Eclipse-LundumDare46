using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroCheck : MonoBehaviour
{
    // Update is called once per frame
    public void CheckSurronding()
    {
        //Debug.Log("!");
        // Temp -> Get Collision trough circle
        Collider2D[] collisionArray = Physics2D.OverlapCircleAll(transform.position, .75f);

        // Check all collisions
        foreach (Collider2D collider in collisionArray)
        {
            IPlayerCanCheck obj = collider.gameObject.GetComponent<IPlayerCanCheck>();

            if (obj != null) { obj.Check(gameObject);}
        }

    }
}
