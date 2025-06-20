using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishInChairScript : MonoBehaviour
{
    public GameObject Character;
    public Animator fish_anim;
    public Animator chair_anim;

    public void StartUp() {
        fish_anim.SetTrigger("Start");
        chair_anim.SetTrigger("Start");
    }

    public void SpawnCharacter()
    {
        Vector2 spawnPos = transform.position;
        spawnPos.y = transform.position.y - 0.3f;
        Instantiate(Character, spawnPos, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
