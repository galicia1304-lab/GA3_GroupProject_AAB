using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CustomerScript : MonoBehaviour
{
    //refrence to navmesh agent
    private NavMeshAgent _agent;
    [SerializeField] private GameObject _Destination;
    

    //state for entering shop and leaving shop
    //enum for testing with inspector
    private enum NPCBehaviour
    {
        EnteringShop,
        LeavingShop
    }

    [SerializeField] private NPCBehaviour currentState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //hanle for component
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
    void Update()
    {
        //set destination for destination
        _agent.SetDestination(_Destination.transform.position);

        switch (currentState)
        {
            case NPCBehaviour.EnteringShop:
                Debug.Log("Customer is entering the shop");
                break;
            case NPCBehaviour.LeavingShop:
                Debug.Log("Customer is leaving the shop");
                break;
        }
        
    }

    //ontrigger checking for potion that customer requested
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PotionProduct")
        {
            currentState = NPCBehaviour.LeavingShop;
        }
    }

}
