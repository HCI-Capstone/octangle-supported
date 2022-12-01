using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirection : MonoBehaviour
{
    public GameObject trackingSpace;
    public float translationGain = 3.0f;
    public float rotationGain = 10.0f;
    
    private Vector3 oldPhysicalPos;
    private Vector3 oldPhysicalRot;
    public bool turnTime = false;


    // Start is called before the first frame update
    void Start()
    {
        oldPhysicalPos = transform.localPosition;
        oldPhysicalRot = transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        // // Get the change in physical position
        // Vector3 deltaPhysicalPos = transform.localPosition - oldPhysicalPos;

        // // Calculate amount of injected translation
        // Vector3 injectedTranslation = deltaPhysicalPos * (translationGain - 1.0f);

        // // Move tracking space
        // if (deltaPhysicalPos.x >= 1.0f || deltaPhysicalPos.z >= 1.0f) {
        //     trackingSpace.transform.Translate(deltaPhysicalPos * 2.0f);
        // }

        // Update old pos
        oldPhysicalPos = transform.localPosition;

        // Get the change in physical position
        Vector3 deltaPhysicalPos = transform.localPosition - oldPhysicalPos;

        // Calculate amount of injected translation
        Vector3 injectedTranslation = deltaPhysicalPos * (translationGain - 1.0f);

        // Move tracking space
        trackingSpace.transform.Translate(injectedTranslation);

        // Update old pos
        oldPhysicalPos = transform.localPosition;

        
        
        // get eulerRotation.y for rotation
        
        //if (turnTime) {
        // Vector3 deltaPhysicalRot = transform.localEulerAngles - oldPhysicalRot;
        // Vector3 injectedRotation = deltaPhysicalRot * (rotationGain - 1.0f);
        // trackingSpace.transform.Rotate(injectedRotation);

        // oldPhysicalRot = transform.localEulerAngles;
            
        //}
    }

    private void OnTriggerEnter(Collider other) {
        turnTime = true;
    }

    private void OnTriggerExit(Collider other) {
        turnTime = false;
    }
}
