using UnityEngine;
using FMODUnity;

public class AudioOneshotScript : MonoBehaviour
{


    //sreialized field to hold audio
    [SerializeField] private EventReference PLayThisSoundHere;



    //sound will be played based on serialized field
    public void PLaySoundHere()
    {
       AudioOneshotManager.Instance.PlaySoundOneshot(PLayThisSoundHere, this.transform.position);
    } 
}
