using UnityEngine;

//this script is used to control mouse with "dialouge editor" package
public class ConversastionHideShowMouse : MonoBehaviour
{

    public void lockMouse()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public  void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
