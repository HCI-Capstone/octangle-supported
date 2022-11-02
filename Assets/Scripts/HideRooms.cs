using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Hides the rooms.
*/
public class HideRooms : MonoBehaviour
{
    public Transform rooms;
    public Transform doors;

    /**
        If a collider enters the HideColliders, iterates
        through all rooms, hiding each object in that room. 
        Also shows all doors, to counteract the hidden doors 
        from being in a room.

        We hide the objects in the room instead of the room,
        since the room has the collider needed to show the
        room again.
    */
    private void OnTriggerEnter(Collider other) {
        foreach (Transform room in rooms) {
            foreach (Transform obj in room) {
                obj.gameObject.SetActive(false);
            }
        }
        
        foreach (Transform door in doors) {
            door.gameObject.SetActive(true);
        }

        Debug.Log("Triggered hide");
    }
}
