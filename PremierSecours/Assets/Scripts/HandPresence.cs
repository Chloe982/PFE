using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{

    public GameObject handModelPrefab;
    private GameObject spawnedHandModel;
    private InputDevice targetDevice;
    private Animator handAnimator;

    public InputDeviceCharacteristics controllerCharacteristics;
    // Start is called before the first frame update
    void Start()
    {  
        spawnedHandModel = Instantiate(handModelPrefab, transform);
        handAnimator = spawnedHandModel.GetComponent<Animator>();
    }

    void UpdatehandAnimation()
    {
        if(targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            handAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            handAnimator.SetFloat("Trigger", 0);
        }

        if(targetDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            handAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
            handAnimator.SetFloat("Grip", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdatehandAnimation();
    }
}
