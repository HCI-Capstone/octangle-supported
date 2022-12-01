using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalCompassController : MonoBehaviour
{
    public Transform tracking;

    // Start is called before the first frame update
    void Start()
    {
        transform.localRotation = Quaternion.Euler(0f, -22.5f, -tracking.localEulerAngles.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0f, -22.5f, -tracking.localEulerAngles.y);
    }
}
