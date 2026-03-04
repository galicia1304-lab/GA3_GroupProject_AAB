using UnityEngine;
using DialogueEditor;

public class conversationStarterPriest : MonoBehaviour
{
    //what dialouge this script wants to play (2 is incorrect potion convo, 1 is correct potion convo)
    [SerializeField] private NPCConversation MyConversastion;
    [SerializeField] private NPCConversation MyConversastion2;

    //only allow the conversastion to be initiated once
    bool willingToTalk = true;

    //bool that decides which conversastion will play (soldier "use potion" script will be able to change this)
    public bool CorrectPotionConversastion = false;

    //E promt game object
    public GameObject PromtObject;

    //refrence to script
    [Header("script refrence")]
    public UsePotion SoldierPotionOutcome;


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
                    //hide E promt
                    //EPromtCanvas.enabled = false;
                    PromtObject.SetActive(false);

                    Debug.Log("this is the bool of the script: " + SoldierPotionOutcome);
                    if (SoldierPotionOutcome.SoldierCorrectPotion == true)
                    {
                        //this makes the conversastion manager START conversastion the was put into the serialized field "myconversastion2"
                        ConversationManager.Instance.StartConversation(MyConversastion);
                        willingToTalk = false;
                    }

                    //the negative conversastion will play by default
                    else
                    {
                        //this makes the conversastion manager START conversastion the was put into the serialized field "myconversastion"
                        ConversationManager.Instance.StartConversation(MyConversastion2);
                        willingToTalk = false;
                    }
                }
            }
        }
    }


}
