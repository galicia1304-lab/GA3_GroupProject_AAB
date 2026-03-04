using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CustomerScript : MonoBehaviour
{
    //note to self, customer currently has no way to enter "wating in shop" state

    //talk to John about this 
    //this is what value the customer gets from the potions they recive
    //int customerRecivedPotionValue1 = 0;
    //int customerRecivedPotionValue2 = 0;

    //refrence to navmesh agent
    private NavMeshAgent _agent;

    //Waypoitns for the npc to navigate towards (what these objects are is designated in the inspector)
    // [] array is for multiple objects 
    [SerializeField] public Transform[] Waypoints;

    //state for entering shop and leaving shop
    //enum for testing with inspector
    private enum NPCBehaviour
    {
        EnteringShop,
        WatingInShop,
        LeavingShop,
        Inactive
    }

    //what behaviour npc is exacuting.
    [SerializeField] private NPCBehaviour currentState;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //handle for component
        _agent = GetComponent<NavMeshAgent>();
        //null check
        if ( _agent == null)
        {
            Debug.LogError("Nav mesh agent is null");
        }
        //set what state script begins in
    }

    // Update is called once per frame
    // states for npcbehaviour 
    void Update()
    {
        //set destination, this is designated in inspector
        switch (currentState)
        {
            // npc begins in this state
            // customer navigates to the store counter 
            case NPCBehaviour.EnteringShop:
                Debug.Log("Customer is entering the shop");
                //speed in regards to deltatime is not needed since the nav mesh agent handles the speed (you can change it there)
                _agent.SetDestination(Waypoints[0].transform.position);
                _agent.isStopped = false;
                break;
            
                //this is not used ohwell
            // customer remains still waiting for the next step/state
            case NPCBehaviour.WatingInShop:
                //need code that prevents the NavMeshAgent fromt jittering in place         
                Debug.Log("Customer wating for potion");
                break;

            // customer got what they want and moves to waypoint awayfrom the player. 
            case NPCBehaviour.LeavingShop:
                _agent.SetDestination(Waypoints[1].transform.position);
                _agent.isStopped = false;
                Debug.Log("Customer is leaving the shop");
                break;

                //this is not used ohwell
            //Npc is not needed anymore and becomes inactive
            case NPCBehaviour.Inactive:

                break;
        }

        //npc should top if their distance to waypaint is less than 2
        if (_agent.remainingDistance < 2.0)
        {
            _agent.isStopped = true;
        }
        
    }


    //thanks to John for helping with transfering the potion information to the npc
    //ontrigger checking for potion that customer requested
    private void OnTriggerEnter(Collider other)
    {
        //if its a potion procced
        //refrence to other only needs to check for tag and not also gameobject
        if(other.tag == "PotionProduct") 
        {
            Transform potion = other.transform; 
           
            //this should be moved elsewhere in regards to npc dialogue
            currentState = NPCBehaviour.LeavingShop;

           //give the potion as an object
           potion.parent = transform;  //give the actual potion to the NPC
           potion.position = Vector3.zero;
           potion.localPosition = Vector3.zero + Vector3.up * 2.0f;
           potion.gameObject.SetActive(false);

           Debug.Log("Customer got Potion, should be hovering over head of npc");
        }

        else if (other.tag == "1stWaypoint")
        {
            currentState = NPCBehaviour.WatingInShop;
            Debug.Log("Customer will now wait in the shop");
        }

    }

}
