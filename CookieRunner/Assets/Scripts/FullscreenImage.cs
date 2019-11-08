using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullscreenImage : MonoBehaviour
{
    void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        float cameraHeight = Camera.main.orthographicSize * 2;
        Vector3 cameraSize = new Vector3(Camera.main.aspect * cameraHeight, cameraHeight, 40);
        Vector3 spriteSize = spriteRenderer.sprite.bounds.size;

        Vector3 scale = transform.localScale;
        if (cameraSize.x >= cameraSize.y)
        { // Landscape (or equal)
            scale *= cameraSize.x / spriteSize.x;
        }
        else
        { // Portrait
            scale *= cameraSize.y / spriteSize.y;
        }

        //transform.position = Vector3.zero; // Optional
        transform.localScale = scale;
    }
}
