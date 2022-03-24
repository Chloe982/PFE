using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    Vector3 destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter (Collision collider)
    {
        if(this.name == "door1")
        {
            destination = GameObject.Find("door4").transform.position;
        }
        else
        {
            destination = GameObject.Find("door1").transform.position;
        }
        collider.transform.position = destination - Vector3.forward * 180;
    }   
}