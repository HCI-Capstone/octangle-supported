using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCompassController : MonoBehaviour
{
    public Transform tracking;

    // Start is called before the first frame update
    void Start()
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, -tracking.eulerAngles.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, -tracking.eulerAngles.y);
    }
}
