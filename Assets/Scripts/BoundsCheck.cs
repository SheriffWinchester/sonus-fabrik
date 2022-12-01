using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour
{
    public GameObject thisObject, m_NewObject;
    Collider2D thisCollider, m_Collider2;
    Vector3 snapPosition = new Vector3(-2, 3, 0);
    GameObject factorySlot;
    Collider2D factorySlotCollider;

    void Start() 
    {
            thisCollider = gameObject.GetComponent<Collider2D>();
            factorySlot = GameObject.FindGameObjectWithTag("FactorySlot");
            factorySlotCollider = factorySlot.GetComponent<Collider2D>();
    }

    void Update() {
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "FactorySlot")
            {
                Debug.Log(collision.gameObject.name);
                gameObject.transform.position = collision.transform.position;
            }
        }
        // if (thisCollider.bounds.Intersects(factorySlotCollider.bounds)) 
        // {
        //     //m_Collider2.transform.position = factorySlot.transform.position;
        //     Debug.Log(factorySlotCollider.name);
        // }
        
    }
}
