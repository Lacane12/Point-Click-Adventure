using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    [System.Serializable]
    public struct Trigger
    {
        public string RequiredItemName;
        public GameObject triggerObject;
        public bool wasActivated;
    }

    public Trigger[] triggers;

    ItemsController controller;
    private void Start()
    {
        controller = ItemsController.Instance;

        foreach (var trigger in triggers)
        {
            trigger.triggerObject.SetActive(false);
        }
    }

    private void Update()
    {
        foreach (var item in controller.items)
        {
            for (int i = 0; i < triggers.Length; i++)
            {
                if (triggers[i].RequiredItemName == item.name && item.has && !triggers[i].wasActivated)
                {
                    triggers[i].triggerObject.SetActive(true);
                    triggers[i].wasActivated = true;
                }
            }
        }
    }
}
