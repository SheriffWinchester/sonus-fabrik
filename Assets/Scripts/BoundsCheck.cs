using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour
{
    GameObject thisObject;
    Collider2D thisCollider;
    Collider2D factorySlotCollider;
    BlockClickMove blockClickMove;
    Vector3 slotPosition;

    void Start() 
    {
        thisCollider = GetComponent<Collider2D>();
    }

    //Obtain a colliding object
    void OnTriggerEnter2D(Collider2D collision)
    {
        factorySlotCollider = collision;
        slotPosition = collision.transform.position;
        Debug.Log("Collision " + collision.gameObject.name);
    }

    //Check whether objects intersect after colliding, then move its position
    void Update() {
        if (factorySlotCollider != null && factorySlotCollider.tag == "FactorySlot")
        {
            if (thisCollider.bounds.Intersects(factorySlotCollider.bounds)) 
            {
                thisCollider.transform.position = factorySlotCollider.transform.position;
            }
        }
    }  
}
