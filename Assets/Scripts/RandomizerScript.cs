using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizerScript : MonoBehaviour
{
    public bool startState = false;
    int activeChild;
    Transform[] childCurrent = new Transform[16];
    void Start()
    {
      //Get access to the tiles  
        for (int i = 0; i < transform.childCount; i++) {
            childCurrent[i] = transform.GetChild(i);
        }   
    }

    void Update()
    {
        if (!startState)
        {
            activeChild = 0;
            for (int i = 0; i < childCurrent.Length; i++) {
                childCurrent[i].transform.gameObject.SetActive(false);
            }
            for (int i = 0; i < childCurrent.Length; i++) {
                if (Random.Range(0, 100) > 50)
                {
                    childCurrent[i].transform.gameObject.SetActive(true);
                    activeChild++;
                }
            }
            if (activeChild < 4)
            {
                Debug.Log("Loop");
                while (activeChild < 4)
                {
                    for (int i = 0; i < childCurrent.Length; i++) {
                        if (Random.Range(0, 100) > 50 && 
                            childCurrent[i].transform.gameObject.activeSelf == false)
                        {
                            childCurrent[i].transform.gameObject.SetActive(true);
                            activeChild++;
                        }
                        if (activeChild >= 4)
                        {
                            break;
                        }
                    }
                }
            }
            startState = true;
            Debug.Log(activeChild);
        }
    }
}
