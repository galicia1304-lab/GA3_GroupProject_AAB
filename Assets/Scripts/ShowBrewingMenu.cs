using UnityEngine;

//Get access to unity UI system (FOR UI COMMANDS)
using UnityEngine.UI;


public class ShowBrewingMenu : MonoBehaviour
{
    //existing canvases
    //public Canvas EPromtCanvas;
    //public Canvas BrewingMenuCanvas;
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
        PromtObject.SetActive(true);
        CanvasObject.SetActive(false);

        //enable player controller
        PlayerController.enabled = true;

        //lock the cursor again
        Cursor.lockState = CursorLockMode.Locked;
    }

    void DisableCanvas()
    {
        CanvasObject.SetActive(false);
    }

    void ActivateCanvas()
    {
        CanvasObject.SetActive(true);
    }
}
