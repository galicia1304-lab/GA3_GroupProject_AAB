using UnityEngine;

public class TutorialCanvasScript : MonoBehaviour
{
    //canvas refrence
    public GameObject CanvasObject;

    //player controller refrence
    public CharacterController PlayerController;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //activate canvas
        CanvasObject.SetActive(true);

        //frezze the player controller
        PlayerController.enabled = false;

        //make mouse visable
        Cursor.lockState = CursorLockMode.None;
    }

    public void closeTutorial()
    {
        //enable player controller
        PlayerController.enabled = true;

        //disable canvas
        CanvasObject.SetActive(false);

        //lock the cursor again
        Cursor.lockState = CursorLockMode.Locked;

        Debug.Log("tutorial button pressed");
    }
}
