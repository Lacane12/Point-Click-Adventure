using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftRepairChecker : MonoBehaviour
{
    public GameObject liftCabin;
    public GameObject wheel;

    public ActivateCutsceneByClick activateCutscene;

    private void Update()
    {
        if (liftCabin.activeInHierarchy && wheel.activeInHierarchy) {
            activateCutscene.Checker = true;
            gameObject.SetActive(false);
        }
            

    }
}
