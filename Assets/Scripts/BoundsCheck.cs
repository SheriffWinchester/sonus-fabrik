using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour
{
    GameObject thisObject;
    public GameObject slotObject;
    Collider2D thisCollider;
    Collider2D factorySlotCollider;
    Vector3 test = new Vector3(3, 3, 3);
    BlockClickMove blockClickMove;

    void Start() 
    {
            thisCollider = GetComponent<Collider2D>();
            factorySlotCollider = slotObject.GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision " + collision.gameObject.name);
        if (collision.gameObject.tag == "FactorySlot")
        {
            blockClickMove.isDragged = false;
            transform.position = collision.transform.position;
        }
    }
    // void Update() {
    //     if (factorySlotCollider.bounds.Intersects(thisCollider.bounds)) 
    //     {
    //         thisCollider.transform.position = factorySlotCollider.transform.position;
    //         Debug.Log(factorySlotCollider.name);
    //     }
    // }  
}
