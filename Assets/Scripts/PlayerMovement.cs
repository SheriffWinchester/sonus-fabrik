using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 0.1f;
    Rigidbody2D rb;
    bool isMoving = false;
    AudioClip m_AudioClip;
    AudioSource audioSrc;
    Vector2 mainPosition = new Vector2(0f, -0.7f);

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
        //rb.transform.position = mainPosition;
        m_AudioClip = audioSrc.clip;
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x = position.x + movementSpeed * horizontal;
        transform.position = position;

        if (rb.velocity.x != 0) {
            isMoving = true;
        }
        else {
            isMoving = false;
        }

        if (isMoving) {
            if (!audioSrc.isPlaying) {
                audioSrc.Play();
            }
        }
        else {
            audioSrc.Stop();
        }
    }
}
