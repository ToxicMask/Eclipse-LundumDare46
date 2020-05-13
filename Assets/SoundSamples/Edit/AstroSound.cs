using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroSound : MonoBehaviour
{

    public AudioSource resuplySound;



    public void PlaySound() {
        PlayResuplySound();
    }


    protected void PlayResuplySound()
    {
        if (resuplySound == null) return;

        resuplySound.Play();
    }
}
