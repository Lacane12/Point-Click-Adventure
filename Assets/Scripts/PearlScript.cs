using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PearlScript : MonoBehaviour, IPointerClickHandler
{
    Animator _animator;
    SpriteRenderer _spriteRenderer;
    public GameObject selector;
    public int NumberOfPearls = 1;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        _spriteRenderer.sortingOrder = 200;
        _animator.SetTrigger("Start");
    }

    public void AddPearls() {

        if (PearlsController.Instance == null)
            return;

        PearlsController.Instance.AddPearls(NumberOfPearls);
    }

    IEnumerator showSelector() {
        selector.SetActive(true);
        yield return new WaitForSeconds(2);
        AddPearls();
        Destroy(gameObject);
    }
}
