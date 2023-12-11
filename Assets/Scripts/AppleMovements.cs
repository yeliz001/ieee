using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AppleMovements : MonoBehaviour
{
    public float speed;
    
    void Update()
    {
    float tempspeed = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        { 
            transform.position += new Vector3(0, 0, tempspeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -tempspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(tempspeed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-tempspeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            transform.position += new Vector3(0, -tempspeed, 0);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, tempspeed, 0);
        }
    }
}
