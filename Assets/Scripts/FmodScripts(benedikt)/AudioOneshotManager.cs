using UnityEngine;
using FMODUnity;

public class AudioOneshotManager : MonoBehaviour
{

    //singleton class
    public static AudioOneshotManager Instance { get; private set; }

    //only one instance of this script should exist in a scene
    private void Awake()
    {
        if (Instance == null)
        {
            Debug.Log("ther should only be 1 audiomanager in this scene");
        }

        Instance = this;
    }

    public void PlaySoundOneshot(EventReference sound, Vector3 worldpos)
    {
        RuntimeManager.PlayOneShot(sound, worldpos);
    }
}
