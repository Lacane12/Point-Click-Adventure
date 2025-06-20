using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ColliderCutsceneActivation : MonoBehaviour
{
    public PlayableDirector director;
    public bool PlayOnce = false;

    bool isPlayed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isPlayed && PlayOnce)
            return;

        if (collision.CompareTag("PlayerTrigger")) {
            director.Play();
            isPlayed = true;
        }
    }
}
