using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockClickMove : MonoBehaviour
{   
    public GameObject selectedObject;
    Vector3 offset;
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);
            Debug.Log(targetObject);
            if (targetObject)
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
                Debug.Log("Yes");

            }
        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
        if (selectedObject) 
        {
            selectedObject.transform.position = mousePosition + offset;
        }
    }
}
