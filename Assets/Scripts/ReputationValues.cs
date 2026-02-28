using UnityEngine;
using UnityEngine.SceneManagement;


public class ReputationValues : MonoBehaviour
{
    //this script is to hold value of reputation, this will change the ending of the game.
    public int soldierReputation = 0;
    public int churchReputation = 0;

    //this is what sets what ending plays in the ending scene
    public int EndingValue = 1;

    //only allow player to end day if both soldier and church have gotten their potion and given feedback.
    public bool CanEndDay = false;

    //what scene should be loaded 
    [Header("Scene")]
    public string sceneToLoad;

    public void SoldierRepIncrease()
    {
        soldierReputation += 1;
    }

    public void ChurchRepIncrease()
    {
        churchReputation += 1;
    } 

    public void EndDay()
    {
        if (soldierReputation == 1)
        {
            if (churchReputation == 1)
            {
                //freedom ending
                EndingValue = 3;
            }

            else
            {
                //obidience ending
                EndingValue = 1;
            }
        }

        else
        {
            //exacution ending
            EndingValue = 2;
        }

        //after aboce checks load the ending scene with this ending value
        SceneManager.LoadScene(sceneToLoad);
    }
}

