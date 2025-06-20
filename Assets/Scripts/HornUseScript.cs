using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornUseScript : MonoBehaviour
{

    Animator _animator;

    [SerializeField]
    AudioSource _audioSource;

    public bool HasHorn = false;
    


    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && HasHorn)
        {
            _animator.SetTrigger("Horn");

            _audioSource.Play();

            LevelManager.Instance.ShowTentacles();
            if (LiftController.Instance != null) {
                LiftController.Instance.StartCutscene();
            }
            
            //isHorning = true;
        }
    }
}
