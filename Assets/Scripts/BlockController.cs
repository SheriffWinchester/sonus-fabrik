using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour
{

    //GameObject tile;
    //Component[] tiles;
    //AudioSource audioSrc;
    Transform[] childCurrent = new Transform[3];
    Transform[] childNext = new Transform[3];
    SpriteRenderer[] childColor = new SpriteRenderer[3];
    //public Camera renderCamera;
    //public GameObject lastHit;
    public Vector3 huy;
    //Transform[] transforms = this.GetComponentsInChildren<Transform>();

    bool statusSequencer = true;
    public float bpm = 60;
    float currentBeatTime;

    float currentTime;
    float nextTime = 0;
    int i = 0;
    int k = 0;
    void Start()
    { 
        //Get access to the tiles  
        for (int i = 0; i < transform.childCount; i++) {
            childCurrent[i] = transform.GetChild(i);
            childColor[i] = childCurrent[i].transform.GetComponent<SpriteRenderer>();
        }    
        childCurrent.CopyTo(childNext, 0);
        //audioSrc = GetComponent<AudioSource>();
        // if (statusSequencer) {
        //     StartCoroutine(SequencePlay());
        // }
    }

    void Update() {
        currentBeatTime = 60 / bpm;
        currentTime = Time.time;  
        
        if (currentTime >= nextTime && i < childCurrent.Length)
        {
            childCurrent[k].transform.GetComponent<BlockState>().isActive = false;
            childCurrent[i].transform.GetComponent<BlockState>().isActive = true;
            //Debug.Log("Active " + i);
            nextTime = currentTime + currentBeatTime;

            k = i;
            i++;
        }
        if (i == childCurrent.Length)
        {
            i = 0;
        }
    }
}