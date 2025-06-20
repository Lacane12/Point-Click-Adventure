
using UnityEngine;

public class CheckForPlayerMoving : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public GameObject cloud;

    void Update()
    {
        if (playerBody.velocity != Vector2.zero) { 
            cloud.SetActive(false);
        }
    }

}
