using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroSound : MonoBehaviour
{

    public AudioSource resuplySound;
    public AudioSource jetBlowSound;



    public void PlayResuplySound()
    {
        if (resuplySound == null) return;

        resuplySound.Play();
    }

    public void PlayJetBlowSound(bool powerOn)
    {
        if (jetBlowSound == null) return;

        if (powerOn && !jetBlowSound.isPlaying)
        {
            jetBlowSound.Play();
        }
        
        else if ( !powerOn && jetBlowSound.isPlaying)
        {
            jetBlowSound.Stop();
        }
    }
}
