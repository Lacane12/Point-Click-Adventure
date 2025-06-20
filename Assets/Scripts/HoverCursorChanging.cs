using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverCursorChanging : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        CursorManager.Instance.SetActiveCursorType(CursorManager.CursorType.Select);
        Debug.Log("ENTER");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        CursorManager.Instance.SetActiveCursorType(CursorManager.CursorType.Arrow);
        Debug.Log("EXIT");
    }

    private void OnDestroy()
    {
        CursorManager.Instance.SetActiveCursorType(CursorManager.CursorType.Arrow);
    }
}
