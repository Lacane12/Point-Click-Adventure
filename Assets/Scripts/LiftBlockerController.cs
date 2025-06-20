using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftBlockerController : MonoBehaviour
{
    public string ItemName;
    ItemsController controller;
    private void Start()
    {
        controller = ItemsController.Instance;
    }
    private void Update()
    {
        foreach (var item in controller.items) {
            if (ItemName == item.name && item.has) { 
                gameObject.SetActive(false);
            }
        }
    }
}
