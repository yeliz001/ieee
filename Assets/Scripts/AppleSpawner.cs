using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject elma;
    [SerializeField] private Transform spawner;
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(elma, spawner);
        }
    }
}
