using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoofEffectController : MonoBehaviour
{
    public Transform character;

    public void ChangePosition() { 
        transform.position = character.position;
    }
}
