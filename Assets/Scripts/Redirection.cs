using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirection : MonoBehaviour
{
    public GameObject trackingSpace;
    public float translationGain = 1.0f;
    
    private Vector3 oldPhysicalPos;


    // Start is called before the first frame update
    void Start()
    {
        oldPhysicalPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the change in physical position
        Vector3 deltaPhysicalPos = transform.localPosition - oldPhysicalPos;

        // Calculate amount of injected translation
        Vector3 injectedTranslation = deltaPhysicalPos * (translationGain - 1.0f);

        // Move tracking space
        trackingSpace.transform.Translate(injectedTranslation);

        // Update old pos
        oldPhysicalPos = transform.localPosition;

        
        
        // get eulerRotation.y for rotation
    }
}
