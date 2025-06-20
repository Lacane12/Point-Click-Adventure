using System.Collections;
using UnityEngine;

public class TentacleScript : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

        animator.StopPlayback();


    }

    public void StartAnimation() {
        StartCoroutine(StartAnim());
    }

    public void EndAnimation()
    {
        StartCoroutine(EndAnim());
    }

    IEnumerator StartAnim() {
        yield return new WaitForSeconds(Random.Range(0f, 1f));
        if(!animator.GetCurrentAnimatorStateInfo(0).IsName("Tentacle1_idle"))
            animator.SetTrigger("Start");
    }

    IEnumerator EndAnim()
    {
        yield return new WaitForSeconds(Random.Range(0f, 0.7f));
        animator.SetTrigger("End");
    }

    
}
