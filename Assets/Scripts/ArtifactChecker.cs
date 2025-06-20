
using UnityEngine;

public class ArtifactChecker : MonoBehaviour
{
    public ActivateCutsceneByClick activateCutscene;

    ArtifactController controller;

    private void Start()
    {
        controller = ArtifactController.Instance;
    }

    private void Update()
    {
        if (controller != null)
        {
            if (controller.Count >= 1) {
                activateCutscene.isAllowed = true;
            }
        }
    }
}
