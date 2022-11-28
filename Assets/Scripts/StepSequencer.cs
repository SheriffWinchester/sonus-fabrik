using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSequencer : MonoBehaviour
{
    //GameObject tile;
    //Component[] tiles;
    AudioSource audioSrc;
    Transform[] child = new Transform[3];
    public Camera renderCamera;
    //Transform[] transforms = this.GetComponentsInChildren<Transform>();
    void Start()
    { 
        //Get access to the tiles  
        for (int i = 0; i < transform.childCount; i++) {
            child[i] = transform.GetChild(i);
            //Debug.Log(child[i]);
        }    
        //Debug.Log(transform.childCount);
        // for (int i = 0; i < child.Lenght; i++) {
        //     Debug.Log(child[i]);
        // } 
        audioSrc = GetComponent<AudioSource>();
    }

    void Update() {  
        // if (Input.GetMouseButtonDown(0)) {  
        //     Vector2 ray = renderCamera.ScreenToWorldPoint(Input.mousePosition); 
        //     RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
        //     Debug.Log(hit.point);  
        //     if(hit.collider != null)
        //     {
        //         Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
        //     }
        // }  
        if (Input.GetKey(KeyCode.Alpha1)){
            Debug.Log("1");
        }
        if (Input.GetKey(KeyCode.Alpha2)){
            Debug.Log("1");
        }
        if (Input.GetKey(KeyCode.Alpha3)){
            Debug.Log("1");
        }
    } 
}
