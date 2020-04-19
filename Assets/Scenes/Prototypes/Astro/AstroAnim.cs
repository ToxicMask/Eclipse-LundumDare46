using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]

public class AstroAnim : MonoBehaviour
{
    // Animator
    [SerializeField] Animator anim;

    // Accel Parameter
    public Vector2 vectorAccel = Vector2.down;


    // Start is called before the first frame update
    void Start()
    {
        // Auto Get
        anim = GetComponent<Animator>();   
    }

    private void Update()
    {
        UpdateAnimation();
    }

    // Update is called once per frame
    void UpdateAnimation()
    {
        // Do nothing if anim is Null
        if (anim == null) return;

        //Update Movement
        anim.SetFloat("moveX", vectorAccel.x);
        anim.SetFloat("moveY", vectorAccel.y);

    }
}
