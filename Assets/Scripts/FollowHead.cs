using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHead : MonoBehaviour
{
    public Transform camera;
    private bool on = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = camera.rotation;
        gameObject.transform.position = camera.position;
    }
}
