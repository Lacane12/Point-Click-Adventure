using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.EventSystems;

public class ActivateCutsceneByClick : MonoBehaviour, IPointerClickHandler
{
    public PlayableDirector director;
    public float distance;
    public bool Checker = false;
    public bool isAllowed = false;
    public bool PlayOnce = false;
    public bool CheckForArtifact = false;
    public void Allow() { 
        isAllowed = true;
    }

    public void Forbid() {
        isAllowed = false;
        Checker = true;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (CheckForArtifact) {

            if (ArtifactController.Instance.Count >= 1) {
                if (Vector2.Distance(transform.position, CharacterMovement.Instance.transform.position) <= distance)
                {
                    if (!Checker && isAllowed)
                    {
                        director.Play();

                        if (PlayOnce)
                        {
                            Forbid();
                        }
                    }
                }
            }
            
        }
        else
        {
            if (Vector2.Distance(transform.position, CharacterMovement.Instance.transform.position) <= distance)
            {
                if (!Checker && isAllowed)
                {
                    director.Play();

                    if (PlayOnce)
                    {
                        Forbid();
                    }
                }
            }
        }
        
    }
}
