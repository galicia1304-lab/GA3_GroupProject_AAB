using UnityEngine;

//Get access to unity UI system (FOR UI COMMANDS)
using UnityEngine.UI;


public class ShowBrewingMenu : MonoBehaviour
{
    //existing canvases
    public Canvas EPromtCanvas;
    public Canvas BrewingMenuCanvas;

    //player controller
    public CharacterController PlayerController;

    void OnTriggerStay(Collider PLayerInside)
    {
        if(PLayerInside.tag == "Player")
        {
            //check if the pressed E
            if (Input.GetKey(KeyCode.E))
            {
                //show brewing Menu Canvas
                BrewingMenuCanvas.enabled = true;

                //hide E promt
                EPromtCanvas.enabled = false;

                //frezze the player controller
                PlayerController.enabled = false;

                //make mouse visable
                Cursor.lockState = CursorLockMode.None;
            }
            //call on ExitButton to close the menu
            if (Input.GetKey(KeyCode.Escape))
            {
                ExitButton();
            }
        }
    }

    //button to close the brewing menu 
    public void ExitButton()
    {
        BrewingMenuCanvas.enabled=false;
        EPromtCanvas.enabled=true;

        //enable player controller
        PlayerController.enabled = true;

        //lock the cursor again
        Cursor.lockState = CursorLockMode.Locked;
    }

}
