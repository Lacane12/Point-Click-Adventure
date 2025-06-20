using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Animator anim;
    public Animator ChairAnim;
    public GameObject Button;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void StopCutscene() {
        anim.SetBool("Cutscene", false);
        Button.SetActive(false);
        ChairAnim.SetTrigger("Start");
    }

    public void ShowButton() {
        Button.SetActive(true);
    }
}
