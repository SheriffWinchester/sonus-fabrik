using UnityEngine;
using System.Collections;

public class BlockState : MonoBehaviour
{

    public bool isActive = false;
    SpriteRenderer childColor;
    AudioSource audioSrc;
    void Start() {
        childColor = GetComponent<SpriteRenderer>();
        audioSrc = GetComponent<AudioSource>();
    }

    void Update() {
        if (isActive) {
            audioSrc.Play();
            childColor.color = Color.green;
        }
        else {
            childColor.color = Color.white;
        }
    }

}