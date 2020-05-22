using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FollowPlayer : MonoBehaviour
{
    //Self Componets
    [SerializeField] Rigidbody2D rb2D;


    public float selfSpeed = 1;

    // Player Components
    public Transform playerTransform;

    private void Start()
    {
        // Auto Get
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Follow player

        if ( playerTransform != null)
        {
            Vector2 targetPosition = playerTransform.position;
            Vector2 selfPosition = transform.position;

            Vector2 direction2Target = ( targetPosition - selfPosition ).normalized;

            //Debug.Log(direction2Target);

            // Update Velocity
            rb2D.velocity = direction2Target * (selfSpeed * Time.fixedDeltaTime);

        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool astroInside = collision.gameObject.CompareTag("Player");

        if (astroInside) { playerTransform = collision.gameObject.transform; Debug.Log("ENTER"); }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        Transform collisionTransform = collision.gameObject.transform;

        if (playerTransform == collisionTransform) { playerTransform = null; Debug.Log("EXIT"); }
    }


    private void OnValidate()
    {
        //No Negatives

        if (selfSpeed < 0) selfSpeed = 0;
        
    }

    /*
     *         if (range < 0) range = 0;
    public float range = 4;
    public CircleCollider2D searchArea;
         

    public void UpdateSearchRange()
    {
        if (searchArea == null)
        {
            Debug.LogError("No Search Area! Assign collider!");
            return;
        }

        // Update 
        searchArea.radius = range;
    }
     */
}
