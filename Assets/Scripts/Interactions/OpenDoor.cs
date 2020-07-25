/// <summary>
/// Author: DeadlyMagikarps/Kosaki Onodera
/// Created: 7/24/2020
/// Description: This class specifies functions relating to opening a door.
/// </summary>

using UnityEngine;
using Interactions;

public class OpenDoor : MonoBehaviour
{
    // Variables
    public Door door;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Test
    public void DoorInteract()
    {
        door.interact();
    }
}
