using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CustomerScript : MonoBehaviour
{
    //refrence to navmesh agent
    private NavMeshAgent _agent;

    //this is what destination the npc is trying to get to (for testing)
    //[SerializeField] private GameObject Destination;


    //Waypoitns for the npc to navigate towards (what these objects are is designated in the inspector)
    // [] array is for multiple objects 
    [SerializeField] public Transform[] Waypoints;

    //state for entering shop and leaving shop
    //enum for testing with inspector
    private enum NPCBehaviour
    {
        EnteringShop,
        WatingInShop,
        LeavingShop
    }

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
        currentState = NPCBehaviour.EnteringShop;
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
                break;

            // customer remains still waiting for the next step/state
            case NPCBehaviour.WatingInShop:
                Debug.Log("Customer wating for potion");
                break;

            // customer got what they want and moves to waypoint awayfrom the player. 
            case NPCBehaviour.LeavingShop:
                _agent.SetDestination(Waypoints[1].transform.position);
                Debug.Log("Customer is leaving the shop");
                break;
        }
        
    }

    //ontrigger checking for potion that customer requested
    private void OnTriggerEnter(Collider other)
    {
        //if its a potion procced
        if(other.gameObject.tag == "PotionProduct") 
        {
            //this should be moved elsewhere in regards to npc dialogue
            currentState = NPCBehaviour.LeavingShop;
            //object with tag is destroyd. creates illusion of npc reciving item (specifie gameobject othervise destroyed object is still visable)
            Destroy(other.gameObject);
            Debug.Log("Customer got Potion");
        }
    }

}
