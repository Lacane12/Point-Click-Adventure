using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControllerScript : MonoBehaviour
{
    private AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip clip) {
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void LoadScene(string SceneName) { 
        SceneManager.LoadScene(SceneName);  
    }

    public void LoadSceneInTheBackground() {
        PlayerPrefs.SetInt("CreditsState", 2);
        StartCoroutine(LoadAsyncScene());
    }

    public void QuitGame() {
        Application.Quit();
    }

    IEnumerator LoadAsyncScene()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);


        while (!asyncLoad.isDone)
        {
            yield return null;
        }

    }

}
