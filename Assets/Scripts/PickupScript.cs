using UnityEngine;

public class PickupScript : MonoBehaviour
{
    //header offer more description in the inspector
    [Header("Pickup Settings")]
    [SerializeField] Transform HoldArea;
    private GameObject heldObj;
    private Rigidbody heldObjRb;

    [Header("Physics Paramater")]
    //range in which objet is picked up
    [SerializeField] private float PickupRange = 5.0f;
    [SerializeField] private float PickupForce = 150f;


    //this scripts allows the player to pickup anything with rigid body, a filter will be for items the player should !only! be able to pick up
    private void Update()
    {
        //mouse being held down to pickup object
        if (Input.GetMouseButtonDown(0))
        {
            if(heldObj == null)
            {
                //raycast check if we hit what we want
                RaycastHit hit;
                if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, PickupRange))
                {
                    //what object the raycast has hit and picks it up
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                //player drops object
                DropObject();
            }
        }
        if (heldObj != null)
        {
            MoveObject();
        }
    }

    //this designate where the object is the be held and at what distance from the player/raycast
    void MoveObject()
    {
        if (Vector3.Distance(heldObj.transform.position, HoldArea.position) > 0.1f)
        {
            Vector3 moveDirection = (HoldArea.position - heldObj.transform.position);
            heldObjRb.AddForce(moveDirection * PickupForce); 
        }
    }

    //object is held by force infront of the player
    void PickupObject(GameObject pickObj)
    {
        //before pickup up object check if the tag is PotionProduct, this is the only items that should be picked up
        if (pickObj.tag == "PotionProduct" && pickObj.activeSelf)
        {
            if (pickObj.GetComponent<Rigidbody>())
            {
                heldObjRb = pickObj.GetComponent<Rigidbody>();
                heldObjRb.useGravity = false;
                heldObjRb.linearDamping = 10;
                heldObjRb.constraints = RigidbodyConstraints.FreezeRotation;

                heldObjRb.transform.parent = HoldArea;
                heldObj = pickObj;
            }
        }
    }

    // this reverses what code aboce does
    void DropObject()
    {
            heldObjRb.useGravity = true;
            heldObjRb.linearDamping = 1;
            heldObjRb.constraints = RigidbodyConstraints.FreezeRotation;

            heldObjRb.transform.parent = null;
            heldObj = null;
        
    }
}
