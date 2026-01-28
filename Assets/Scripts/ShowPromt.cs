using System.Xml.Serialization;
using UnityEngine;

//Get access to unity UI system (FOR UI COMMANDS)
using UnityEngine.UI;

public class ShowPromt : MonoBehaviour
{
    //This is for canvas with E promt (brewing table)
    public Canvas EPromtCanvas;

    void OnTriggerEnter(Collider PlayerCapsule)
    {
        //player charachter mus have the tag "player" for this to work
        if (PlayerCapsule.tag == "Player");
        {
            Debug.Log("Player should get E promt now");
            //assigned canvas should now be visalbe
            EPromtCanvas.enabled = true;
        }
    }

    void OnTriggerExit(Collider LeavingObject)
    {
        if (LeavingObject.tag == "Player")
        {
            Debug.Log("Player should not see E promt now");
            EPromtCanvas.enabled = false;
        }
    }
}
