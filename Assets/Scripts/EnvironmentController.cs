using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    This makes sure that, at the start of each run,
    all rooms are set to active. This prevents issues
    if we've hidden a room during debugging.
*/
public class EnvironmentController : MonoBehaviour
{
    public Transform rooms;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform room in rooms) {
            foreach (Transform obj in room) {
                obj.gameObject.SetActive(false);
            }
        }
    }
}
