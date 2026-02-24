using UnityEngine;
using DialogueEditor;

public class conversationStarter : MonoBehaviour
{
    //what dialouge this script wants to play
    [SerializeField] private NPCConversation MyConversastion;

    //only allow the conversastion to be initiated once
    bool willingToTalk = true;

    private void OnTriggerStay(Collider other)
    {
        //do not start conversastion if it has already played
        if (willingToTalk == true)
            
        {
            //check for player
            if (other.tag == "Player")
            {
                //check for input key E
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //this makes the conversastion manager START conversastion the was put into the serialized field "myconversastion"
                    ConversationManager.Instance.StartConversation(MyConversastion);
                    willingToTalk = false;
                }
            }
        }
    }


}
