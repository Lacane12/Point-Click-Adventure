using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FihInChairScript : MonoBehaviour
{
    public GameObject character;
    public GameObject chair;
    public GameObject frame;

    public Camera2D cameraScript;

    [Space(10)]

    public FadeInOutScript outScript;
    public Animator anim;
    public AudioSource UP_source;


    public void startAnim() {
        anim.SetTrigger("Start");
    }

    public void PlaySound() {
        UP_source.Play();
    }

    public void StartFade() {
        outScript.FadeIn();
    }

    public void ShowStart()
    {
        character.SetActive(true);
        chair.SetActive(true);
        frame.SetActive(true);
        cameraScript.enabled = true;

        gameObject.SetActive(false);
    }
}
