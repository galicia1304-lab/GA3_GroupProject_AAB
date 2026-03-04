using System.Xml.Serialization;
using UnityEngine;

//Get access to unity UI system (FOR UI COMMANDS)
using UnityEngine.UI;

public class ShowPromt : MonoBehaviour
{
    //This is for canvas with E promt (brewing table)
    //public Canvas PromtCanvas;
    public GameObject PromtObject;

    //these are for hiding the E promt with "conversastion starter" script
    public bool HideForConversastion = false;
    private bool DontShowPromtAgain = true; 

    void OnTriggerEnter(Collider PlayerCapsule)
    {
        //player charachter mus have the tag "player" for this to work
        if (PlayerCapsule.tag == "Player")
        {
            if (HideForConversastion == false)
            {
                Debug.Log("Player should get E promt now");
                //assigned canvas should now be visalbe
                //PromtCanvas.enabled = true;
                PromtObject.SetActive(true);
            }

            else if (HideForConversastion == true)
            {
                if (DontShowPromtAgain == true)
                {
                    Debug.Log("Player should get E promt now");
                    //assigned canvas should now be visalbe
                    //PromtCanvas.enabled = true;
                    PromtObject.SetActive(true);
                }
            }
        }
    }

    void OnTriggerExit(Collider LeavingObject)
    {
        if (LeavingObject.tag == "Player")
        {
            Debug.Log("Player should not see E promt now");
            //PromtCanvas.enabled = false;
            PromtObject.SetActive(false);
        }
    }

    public void DisableConvoPromt()
    {
        DontShowPromtAgain = false;
    }
}
