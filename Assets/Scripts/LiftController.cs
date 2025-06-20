using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LiftController : MonoBehaviour
{
    public SpriteRenderer bridge;
    public static LiftController Instance;
    [Space(10)]
    public PlayableDirector director;
    public float distance;
    public GameObject wheel;

    private void Start()
    {
        Instance = this;
    }

    public void StartCutscene()
    {
        if (!wheel.activeInHierarchy)
            return;

        if (Vector2.Distance(CharacterMovement.Instance.transform.position, transform.position) <= distance)
        {
            bridge.sortingOrder = 160;
            director.Play();
        }
    }
}

    

    

