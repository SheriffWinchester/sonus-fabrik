using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour
{
    Transform[] childCurrent = new Transform[16];
    SpriteRenderer[] childColor = new SpriteRenderer[16];
    public float bpm = 60;
    float currentTime, currentBeatTime;
    float nextTime = 0;
    int i, k = 0;
    void Start()
    { 
        //Get access to the tiles  
        for (int i = 0; i < transform.childCount; i++) {
            childCurrent[i] = transform.GetChild(i);
            childColor[i] = childCurrent[i].transform.GetComponent<SpriteRenderer>();
        }    
    }
    void Update() {
        currentBeatTime = 60 / bpm;
        currentTime = Time.time;  
        //Step sequencing
        if (currentTime >= nextTime && i < childCurrent.Length)
        {
            //Swap magic of elements
            childCurrent[k].transform.GetComponent<BlockState>().isActive = false;
            childCurrent[i].transform.GetComponent<BlockState>().isActive = true;

            nextTime = currentTime + currentBeatTime;

            k = i;
            i++;
        }

        //When reached to the end of the array - return to the start
        if (i == childCurrent.Length)
        {
            i = 0;
        }
    }
}