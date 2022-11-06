using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redirection : MonoBehaviour
{
    private float oldPos;

    // Start is called before the first frame update
    void Start()
    {
        oldPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (oldPos != transform.position.x) {
            transform.position = new Vector3(transform.position.x * 3, transform.position.y, transform.position.z);
            oldPos = transform.position.x;
        }
    }
}
