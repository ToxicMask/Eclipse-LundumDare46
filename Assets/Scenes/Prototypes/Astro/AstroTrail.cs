using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroTrail : MonoBehaviour
{

    public Transform astroRoot;
    [SerializeField] AstroAnim astroAnim;
    [SerializeField] AstroMove astroMove;

    public TrailRenderer rightTrail;
    public TrailRenderer leftTrail;

    // Start is called before the first frame update
    void Start()
    {
        astroRoot = transform.parent;
        astroAnim = astroRoot.GetComponent<AstroAnim>();
        astroMove = astroRoot.GetComponent<AstroMove>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Emition
        bool jetEmiting = (astroMove.inputVector != Vector2.zero);

        rightTrail.emitting = jetEmiting;
        leftTrail.emitting = jetEmiting;


        // Direction
        Vector2 trailVector = astroAnim.vectorFront;

        float newAngle = Mathf.Rad2Deg * Mathf.Atan2(trailVector.y, trailVector.x);

        float correctionAngle = 90f;

        transform.rotation = Quaternion.Euler(0, 0, newAngle + correctionAngle);
    }
}
