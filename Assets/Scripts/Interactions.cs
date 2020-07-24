using UnityEngine;

/// <summary>
/// Author: DeadlyMagikarps/Kosaki Onodera
/// Created: 7/24/2020
/// Description: Namespace to contain all types of interactions. This is a base class.
/// </summary>
namespace Interactions {
    // Variables

    /// <summary>
    /// Author: DeadlyMagikarps/Kosaki Onodera
    /// Created: 7/24/2020
    /// Description: This class has basic information regarding interaction of a door and how it is opened.
    /// </summary>
    public class Door : MonoBehaviour
    {
        public bool NearDoor()
        {
            print("Near Door!");
            return isNearDoor;
        }

        public void OpenDoor()
        {
            if (isDoor)
            {
                // Grab the component, set animation, and "open" the door. Can activate an audio cue or text, or something.
                isDoorOpened = true;
            }
        }

        public void CloseDoor()
        {
            // Close the door.
        }

        protected bool isNearDoor = true;
        protected bool isDoorOpened;
        protected bool isDoor = true;
    }
}
