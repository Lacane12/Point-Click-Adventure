using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemScript : MonoBehaviour, IPointerClickHandler
{
    Animator _animator;
    SpriteRenderer _spriteRenderer;
    Collider2D _collider;
    public GameObject selector;
    public string ItemName;


    private void Start()
    {
        _collider = GetComponent<Collider2D>();
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _spriteRenderer.sortingOrder = 200;
        _collider.enabled = false;
        _animator.SetTrigger("Start");
        
    }

    public void AddItem()
    {
        ItemsController.Instance.AddItem(ItemName);
    }

    IEnumerator showSelector()
    {
        selector.SetActive(true);
        yield return new WaitForSeconds(2);
        AddItem();
        Destroy(gameObject);
    }
}
