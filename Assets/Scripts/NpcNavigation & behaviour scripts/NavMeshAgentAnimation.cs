using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentAnimation : MonoBehaviour
{
    //get a refrence to what navmesh agent is being refrenced
    public NavMeshAgent agent;

    //anim will be set as the animator component 
    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //this if for chaning animation in the animator based of the velocity of navmesh agent
        anim.SetFloat("Speed", agent.velocity.magnitude);
    }
}
