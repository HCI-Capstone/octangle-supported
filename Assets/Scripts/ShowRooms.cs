using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Shows the rooms.
*/
public class ShowRooms : MonoBehaviour
{
    public int id;

    /**
        If a collider enters that room's collider, sets
        all objects in the room to active. Also hides
        all doors except the door you're at to prevent
        confusion once you enter the room.
    */
    private void OnTriggerEnter(Collider other) {
        foreach (Transform obj in this.transform) {
            obj.gameObject.SetActive(true);
        }

        Debug.Log("Triggered room" + this.name.Substring(this.name.Length));
    }
}
