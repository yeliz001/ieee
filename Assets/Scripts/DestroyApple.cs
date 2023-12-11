using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyApple : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
