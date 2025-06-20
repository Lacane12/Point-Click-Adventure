using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeightAutoPlacer : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public bool Dynamic = false;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        if (Dynamic)
            return;

        if (spriteRenderer != null)
            spriteRenderer.sortingOrder = -Mathf.RoundToInt(transform.position.y * 10);
    }

    private void Update()
    {
        if(!Dynamic)
            return;

        if (spriteRenderer != null)
            spriteRenderer.sortingOrder = -Mathf.RoundToInt(transform.position.y * 10);
    }
}
