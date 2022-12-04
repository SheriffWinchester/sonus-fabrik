using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockClickMove : MonoBehaviour
{   
    GameObject selectedObject;
    Vector3 offset;
    Vector3 mousePosition;
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Click with LMB, check if an object is required and obtain it
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            if (targetObject && targetObject.tag == "Ground")
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }

        //If LMB is unpressed then nullify the object variable
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
        //Move the object
        if (selectedObject) 
        {
            selectedObject.transform.position = mousePosition + offset;
        }
    }
}
