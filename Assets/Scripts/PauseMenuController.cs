using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    public GameObject PauseCanvas;
    public GameObject MainMenuCanvas;

    bool isPaused = false;
    void Update()
    {
        if (MainMenuCanvas.activeInHierarchy)
            return;

        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (!isPaused) {
                ShowPauseMenu();
            }
            else
            {
                HidePauseMenu();
            }
        }
    }

    public void ShowPauseMenu() {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void HidePauseMenu()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
