using UnityEngine;
using System.Collections;

public class BlockState : MonoBehaviour
{
    public bool isActive;
    public bool isPlayed;
    SpriteRenderer childColor;
    AudioSource audioSrc;
    public AudioClip audioClip;
    int i = 0;
    void Start() 
    {
        childColor = GetComponent<SpriteRenderer>();
        audioSrc = GetComponent<AudioSource>();
    }

    void Update() 
    {
        if (isActive) 
        {
            if (isPlayed)
            {
                if (audioSrc.isPlaying == false && i < 1) 
                {
                    audioSrc.PlayOneShot(audioClip);
                    i++;
                }
                childColor.color = Color.green;
            }
        }
        else 
        {
            childColor.color = Color.white;
            i = 0;
        }
    }

}