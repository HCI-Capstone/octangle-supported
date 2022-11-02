using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
    Functions as a method for getting the ID
    of the door, so we know which room each door is
    associated with. This is used for showing/hiding
    the rooms.
*/
public class DoorID : MonoBehaviour
{
    public int ID;
    
    public int getID() {
        return ID;
    }
}
