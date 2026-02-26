using UnityEngine;
using UnityEngine.AI;

public class BirdNavigationScript : MonoBehaviour
{
    //this scrip copies from customer script

    public GameObject CanvasFeedbackLetter;

    private NavMeshAgent _agent;
    [SerializeField] public Transform[] Waypoints;
    [SerializeField] private NPCBehaviour currentState;

    private enum NPCBehaviour
    {
        Inactive,
        DeliveringLetter,
        ExitingShop
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //handle for component
        _agent = GetComponent<NavMeshAgent>();
        //null check
        if (_agent == null)
        {
            Debug.LogError("Nav mesh agent is null");
        }
        //set what state npc begins in
        currentState = NPCBehaviour.Inactive;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState) 
        { 
            case NPCBehaviour.Inactive:
                _agent.isStopped = true; 
                break;     
            
            case NPCBehaviour.DeliveringLetter:
                _agent.SetDestination(Waypoints[0].transform.position);
                _agent.isStopped = false; 
                break;

            case NPCBehaviour.ExitingShop:
                _agent.SetDestination(Waypoints[1].transform.position);
                _agent.isStopped = false;
                break;
        }

        //npc should stop if their distance to waypaint is less than 2
        if (_agent.remainingDistance < 2.0)
        {
            _agent.isStopped = true;
        }

    }

    //cheking for the lette delivery
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "DeliverdLetter")
        {


            //move back after delivering letter.
            currentState = NPCBehaviour.ExitingShop;
        }
    }
}
