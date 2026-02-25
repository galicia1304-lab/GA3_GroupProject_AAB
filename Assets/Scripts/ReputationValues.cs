using UnityEngine;

public class ReputationValues : MonoBehaviour
{
    //this script is to hold value of reputation, this will change the ending of the game.
    public int soldierReputation = 0;
    public int churchReputation = 0;

    //only allow player to end day if both soldier and church have gotten their potion and given feedback.
    public bool CanEndDay = false;

}

