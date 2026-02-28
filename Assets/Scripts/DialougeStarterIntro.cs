using DialogueEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DialougeStarterIntro : MonoBehaviour
{
    //what scene should be loaded 
    [Header("Scene")]
    public string sceneToLoad;

    //what dialouge this script wants to play
    [SerializeField] private NPCConversation MyConversastion;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //when scene opens start the dialouge script
        //this makes the conversastion manager START conversastion the was put into the serialized field "myconversastion"
        ConversationManager.Instance.StartConversation(MyConversastion);
        Debug.Log("scene start with conversastion");
    }

    //load specifiied scene on event
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
