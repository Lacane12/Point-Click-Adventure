using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemsController : MonoBehaviour
{
    [System.Serializable]
    public struct Item
    {
        public string name;
        public bool has;
    }

    public Item[] items;

    public static ItemsController Instance;

    private void Awake()
    {
        Instance = this;
    }

    public void AddItem(string itemName) {
        for (int i = 0; i < items.Length; i++)
        {
            if (itemName == items[i].name) {
                items[i].has = true;
            }
        }
    }


}
