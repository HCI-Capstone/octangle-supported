using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform controller;
    public bool pickedUp = false;

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
    }

    private void OnTriggerStay(Collider other) {
        pickedUp = true;
        controller = other.gameObject.transform;
    }
}
