using DialogueEditor;
using UnityEngine;

public class EndingDialogueStarter : MonoBehaviour
{
    //default ending variable other scripts will call on this to change this
    public int EndingVariable = 1;

    //what dialouge this script wants to play
    [SerializeField] private NPCConversation Ending1;
    [SerializeField] private NPCConversation Ending2;
    [SerializeField] private NPCConversation Ending3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (EndingVariable == 1)
        {
            ConversationManager.Instance.StartConversation(Ending1);
        }

        else if (EndingVariable == 2)
        {
            ConversationManager.Instance.StartConversation(Ending2);
        }

        else if (EndingVariable == 3) 
        {
            ConversationManager.Instance.StartConversation(Ending3);
        }
    }

    //other scripts call on this to set what ending is to play
    public void SetEndingTo1()
    {
        //loyalty ending
        EndingVariable = 1;
    }
    public void SetEndingTo2()
    {
        //refusal
        EndingVariable = 2;
    }
    public void SetEndingTo3()
    {
        //freedom
        EndingVariable = 3;
    }

    //end game with this void (when last dialogue option is clicked)
    public void ENDGAME()
    {
        Application.Quit();
    }
}
