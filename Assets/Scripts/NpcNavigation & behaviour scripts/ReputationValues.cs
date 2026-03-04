using DialogueEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReputationValues : MonoBehaviour
{
    //this is what sets what ending plays in the ending scene
    public static int EndingValue = 1;

    //what scene should be loaded 
    [Header("Scene")]
    public string sceneToLoad;


    //obidience ending
    public void ending1()
    {
        EndingValue = 1;
        //next scene will load after a ending void will be called
        SceneManager.LoadScene(sceneToLoad);
    }

    //exacution ending
    public void ending2()
    {
        EndingValue = 2;
        //next scene will load after a ending void will be called
        SceneManager.LoadScene(sceneToLoad);
    }

    //freedom ending
    public void ending3()
    {
        EndingValue = 3;
        //next scene will load after a ending void will be called
        SceneManager.LoadScene(sceneToLoad);
    }

}

