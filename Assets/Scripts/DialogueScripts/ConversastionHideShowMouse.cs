using UnityEngine;

//this script is used to control mouse with "dialouge editor" package
public class ConversastionHideShowMouse : MonoBehaviour
{

    //player controller refrence
    public CharacterController PlayerController;

    //player resumes 1st person controls 
    public void lockMouse()
    {
        //player can no longer use their mouse 
        Cursor.lockState = CursorLockMode.Locked;
        //frezze the player controller
        PlayerController.enabled = true;
    }

    //player interacts with ui without 1st person controls
    public  void UnlockMouse()
    {
        //player can interact with ui
        Cursor.lockState = CursorLockMode.None;
        //frezze the player controller
        PlayerController.enabled = false;
    }
}
