using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HornItemScript : MonoBehaviour, IPointerClickHandler
{
    public float distance = 2f;

    public HornUseScript hornUse;
    public GameObject HornIcon;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Vector2.Distance(transform.position, CharacterMovement.Instance.transform.position) <= distance)
        {
            hornUse.HasHorn = true;
            HornIcon.SetActive(true);
            Destroy(gameObject);
        }
    }
}
