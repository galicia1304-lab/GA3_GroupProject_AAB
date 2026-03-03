using UnityEngine;
using UnityEngine.SceneManagement;


public class ReputationValues : MonoBehaviour
{
    //this script is to hold value of reputation, this will change the priset dialouge.
    public int soldierReputation = 0;
 

    //this is what sets what ending plays in the ending scene
    public int EndingValue = 1;

    //what scene should be loaded 
    [Header("Scene")]
    public string sceneToLoad;

    public void SoldierRepIncrease()
    {
        soldierReputation += 1;
    }


    //obidience ending
    public void ending1()
    {
        EndingValue = 1;
        //next scene will load after a ending void will be called
        SceneManager.LoadScene(sceneToLoad);
    }

    public void ending2()
    {
        EndingValue = 2;
        //next scene will load after a ending void will be called
        SceneManager.LoadScene(sceneToLoad);
    }

    public void ending3()
    {
        EndingValue = 3;
        //next scene will load after a ending void will be called
        SceneManager.LoadScene(sceneToLoad);
    }

}

