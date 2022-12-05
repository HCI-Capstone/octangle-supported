using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirection : MonoBehaviour
{
    public GameObject trackingSpace;
    public float translationGain = 1.0f;
    public float rotationGain = 1.0f;
    public float rotationGainWhenActive = 0.66f;
    
    private Vector3 oldPhysicalPos;
    private float oldPhysicalRot;
    public bool turnTime = true;

    public bool compassOn = false;
    public GameObject compasses;

    public bool boundaryOn = false;

    // Start is called before the first frame update
    void Start()
    {
        oldPhysicalPos = transform.localPosition;
        oldPhysicalRot = transform.localEulerAngles.y;
        compasses.SetActive(false);
        compassOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two)) {
            if (compassOn) {
                compasses.SetActive(false);
                compassOn = false;
            }

            else {
                compasses.SetActive(true);
                compassOn = true;
            }
        }

        // boundaryCheck();

        // // Get the change in physical position
        // Vector3 deltaPhysicalPos = transform.localPosition - oldPhysicalPos;

        // // Calculate amount of injected translation
        // Vector3 injectedTranslation = deltaPhysicalPos * (translationGain - 1.0f);

        // // Move tracking space
        // if (deltaPhysicalPos.x >= 1.0f || deltaPhysicalPos.z >= 1.0f) {
        //     trackingSpace.transform.Translate(deltaPhysicalPos * 2.0f);
        // }

        // Update old pos
        // oldPhysicalPos = transform.localPosition;

        // Get the change in physical position
        Vector3 deltaPhysicalPos = transform.localPosition - oldPhysicalPos;

        // Calculate amount of injected translation
        Vector3 injectedTranslation = deltaPhysicalPos * (translationGain - 1.0f);

        // Move tracking space
        trackingSpace.transform.Translate(injectedTranslation);

        // Update old pos
        oldPhysicalPos = transform.localPosition;

        // get eulerRotation.y for rotation

        //if (turnTime)
        //{
        float deltaPhysicalRot = transform.localEulerAngles.y - oldPhysicalRot;
        float rotSign = Mathf.Sign(deltaPhysicalRot);

        if (deltaPhysicalRot < 0.0)
        {
            deltaPhysicalRot += 360.0f;
        }
        if (deltaPhysicalRot > 180.0f)
        {
            deltaPhysicalRot = 360.0f - deltaPhysicalRot;
        }

        float injectedRotation = deltaPhysicalRot * (rotationGain - 1.0f) * rotSign;
        trackingSpace.transform.RotateAround(transform.position, Vector3.up, injectedRotation);

        oldPhysicalRot = transform.localEulerAngles.y;

        //}
    }

    float degrees_bounded(float degIn)
    {
        while (degIn >= 360.0f)
        {
            degIn -= 360.0f;
        }

        while (degIn < 0.0)
        {
            degIn += 360.0f;
        }


        return degIn;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Corner")
            rotationGain = rotationGainWhenActive;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Corner")
            rotationGain = 1.0f;
    }
}
