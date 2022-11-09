using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger) >= 0.3f) {
            this.GetComponent<BoxCollider>().enabled = true;
        }

        else if (OVRInput.Get(OVRInput.Axis1D.SecondaryHandTrigger) >= 0.3f) {
            this.GetComponent<BoxCollider>().enabled = true;
        }

        else {
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
