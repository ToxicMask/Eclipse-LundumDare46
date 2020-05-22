using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceMine : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("!");

        IExplosionContact affectedBody = collision.gameObject.GetComponent<IExplosionContact>();

        if (affectedBody != null)
        {
            affectedBody.ExplosionAffect();
            Destroy(gameObject);
        }

        
    }
}
