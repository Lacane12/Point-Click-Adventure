using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CreditIntroController : MonoBehaviour
{
    public PlayableDirector creditsDirector;
    public PlayableDirector introDirector;

    private void Start()
    {
        if (PlayerPrefs.GetInt("CreditsState") == 1 || PlayerPrefs.GetInt("CreditsState") == 0) {
            introDirector.Play();
        }
        if (PlayerPrefs.GetInt("CreditsState") == 2) { 
            creditsDirector.Play();
        }

        PlayerPrefs.SetInt("CreditsState", 1);
    }
}
