using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AppleCollider : MonoBehaviour
{
    private int appleCount=0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sepet")) ;
        {
            appleCount++;
            Destroy(other.gameObject);
            print(appleCount);
        }
    }   
}
