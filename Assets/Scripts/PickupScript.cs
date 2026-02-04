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
                    //what object the raycast has hit
                    PickupObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }
        if (heldObj != null)
        {
            MoveObject();
        }
    }

    void MoveObject()
    {
        if (Vector3.Distance(heldObj.transform.position, HoldArea.position) > 0.1f)
        {
            Vector3 moveDirection = (HoldArea.position - heldObj.transform.position);
            heldObjRb.AddForce(moveDirection * PickupForce); 
        }
    }


    void PickupObject(GameObject pickObj)
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
