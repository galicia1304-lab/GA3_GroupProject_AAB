using UnityEngine;
using FMODUnity;

public class AudioOneshotScript : MonoBehaviour
{
    //this is a singleton class
    public static AudioOneshotScript instance {  get; private set; }

    //sreialized field to hold audio
    [SerializeField] private EventReference PLayThisSoundHere;

    private void Awake()
    {
        if (instance == null)
        {
            Debug.Log("there shouldnt be more than 1 audioOneshot in this scene");
        }
        instance = this;
    }

    //public void to play sound oneshot at world posistion
    public void PlayOneShot(EventReference sound, Vector3 worldpos)
    {
        RuntimeManager.PlayOneShot(sound, worldpos);
    }

    //sound will be played based on serialized field
    public void PLaySoundHere()
    {
        AudioOneshotScript.instance.PlayOneShot(PLayThisSoundHere, this.transform.position);
    }
}
