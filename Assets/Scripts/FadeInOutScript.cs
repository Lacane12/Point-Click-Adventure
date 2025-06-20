using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInOutScript : MonoBehaviour
{
    public Image image;
    public float fadeTime = 3f;
    private YieldInstruction fadeInstruction = new YieldInstruction();


    public void FadeOut() 
    {
        image.gameObject.SetActive(true);
        StartCoroutine(FadeOut(image));
    }

    public void FadeIn()
    {
        image.gameObject.SetActive(true);
        StartCoroutine(FadeIn(image));
    }


    IEnumerator FadeOut(Image image)
    {
        yield return new WaitForSeconds(2);
        float elapsedTime = 0.0f;
        Color c = image.color;
        while (elapsedTime < fadeTime)
        {
            yield return fadeInstruction;
            elapsedTime += Time.deltaTime;
            c.a = 1.0f - Mathf.Clamp01(elapsedTime / fadeTime);
            image.color = c;
        }

        //StartCoroutine(FadeIn(image));
    }

    IEnumerator FadeIn(Image image)
    {
        yield return new WaitForSeconds(0.5f);
        float elapsedTime = 0.0f;
        Color c = image.color;
        while (elapsedTime < fadeTime)
        {
            yield return fadeInstruction;
            elapsedTime += Time.deltaTime;
            c.a = Mathf.Clamp01(elapsedTime / fadeTime);
            image.color = c;
        }

        StartCoroutine(FadeOut(image));
    }
}
