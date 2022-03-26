using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class teleport : MonoBehaviour
{

    public GameObject origin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void teleportToInconscience()
    {
        origin.transform.position = new Vector3(-4f, 0f, 0f);
        
    }
    public void teleportToDefibrilateur()
    {
        origin.transform.position = new Vector3(0f, 0f, 4f);

    }
    public void teleportToBrulure()
    {
        origin.transform.position = new Vector3(4f, 0f, 0f);

    }
    public void teleportToMainRoom()
    {
        origin.transform.position = new Vector3(0f, 0f, 0f);

    }
}
