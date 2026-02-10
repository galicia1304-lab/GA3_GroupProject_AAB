using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CustomerScript : MonoBehaviour
{
    //note to self, customer currently has no way to enter "wating in shop" state

    //talk to John about this 
    //this is what value the customer gets from the potions tehy recive
    //public GameObject PotionValues;
    //[SerializeField] int customerPotionValue;

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
        LeavingShop
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

            //here is the npc taking in the value of the potion which will affect the outcome of the narrative
            //customerPotionValue = PotionValues.GetComponent<ReputationValues>().soldierReputation;
            Debug.Log("print here waht ingridient numbers are in the potion");

            //object with tag is destroyd. creates illusion of npc reciving item (specifie gameobject othervise destroyed object is still visable)
            Destroy(other.gameObject);
            Debug.Log("Customer got Potion");
        }
    }

}
