using UnityEngine;

//Get access to unity UI system (FOR UI COMMANDS)
using UnityEngine.UI;

// [IMPORTANT!]
// this scrit Is used to call multiple canvases but was orignially only named ShowBrewingMenu  

public class ShowBrewingMenu : MonoBehaviour
{
    //this bool exists if the promt shouldnt be shown
    public bool NotShowPromtOnExit = false;

    //existing canvases
    //promt canvas
    //main canvas to be shown
    public GameObject PromtObject;
    public GameObject CanvasObject;

    //player controller refrence
    public CharacterController PlayerController;

    void OnTriggerStay(Collider PLayerInside)
    {
        if(PLayerInside.tag == "Player")
        {
            //check if the pressed E
            if (Input.GetKey(KeyCode.E))
            {
                //show brewing Menu Canvas
                //BrewingMenuCanvas.enabled = true;
                CanvasObject.SetActive(true);

                //hide E promt
                //EPromtCanvas.enabled = false;
                PromtObject.SetActive(false);

                //frezze the player controller
                PlayerController.enabled = false;

                //make mouse visable
                Cursor.lockState = CursorLockMode.None;
            }
            //call on ExitButton to close the menu
            //for some reason this doesnt work when player controller.enabled is set to false !?
            if (Input.GetKey(KeyCode.Escape))
            {
                ExitButton();
            }
        }
    }

    //button to close the brewing menu 
    public void ExitButton()
    {
        Debug.Log("Exit button pressed");
        //BrewingMenuCanvas.enabled=false;
        //EPromtCanvas.enabled=true;
        CanvasObject.SetActive(false);

        if (NotShowPromtOnExit == true)
        {
            //e promt is not to be shown again            
            PromtObject.SetActive(false);
        }

        else
        {
            PromtObject.SetActive(true);
        }

        //dont use "return" in if statements you want code below to run

        //enable player controller
        PlayerController.enabled = true;

        //lock the cursor again
        Cursor.lockState = CursorLockMode.Locked;
    }

}
