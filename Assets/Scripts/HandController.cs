using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    private bool isItOn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<BoxCollider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One)) {
            if (isItOn) {
                this.GetComponent<BoxCollider>().enabled = true;
                isItOn = false;
            }

            else {
                this.GetComponent<BoxCollider>().enabled = true;
                isItOn = true;
            }
        }
    }
}
