using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMaskSprite : MonoBehaviour
{
    private void Awake()
    {
        // Config spritemask
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();

        if (sprite != null) sprite.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
    }
}
