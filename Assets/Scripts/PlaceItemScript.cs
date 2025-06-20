using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaceItemScript : MonoBehaviour, IPointerClickHandler
{
    public GameObject itemObject;

    public void OnPointerClick(PointerEventData eventData)
    {
        itemObject.SetActive(true);
        gameObject.SetActive(false);
        
        Destroy(gameObject);
    }
}
