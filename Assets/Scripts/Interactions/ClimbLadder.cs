/// <summary>
/// Author: DeadlyMagikarps/Kosaki Onodera
/// Created: 7/24/2020
/// Description: This class specifies function to climbing a ladder
/// </summary>

using UnityEngine;
using Interactions;

public class ClimbLadder : MonoBehaviour
{
    // Variables
    public Ladder ladder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LadderInteract()
    {
        ladder.interact();
    }
}
