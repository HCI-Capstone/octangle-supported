using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform controller;
    public bool pickedUp = false;
    private bool on = false;
    public GameObject compasses;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickedUp == true) {
            transform.position = controller.position;
            transform.rotation = controller.rotation;
        }

        if (OVRInput.GetDown(OVRInput.Button.Two)) {
            if (on) {
                compasses.SetActive(false);
                on = false;
            }

            else {
                compasses.SetActive(true);
                on = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        pickedUp = true;
        controller = other.gameObject.transform;
    }

    private void OnTriggerExit(Collider other) {
        pickedUp = false;
    }
}
