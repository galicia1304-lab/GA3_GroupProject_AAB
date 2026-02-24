using UnityEngine;

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
