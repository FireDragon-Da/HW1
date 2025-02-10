using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Controller : MonoBehaviour
{
    public Sprite newSprite; 
    private Sprite originalSprite; 
    private SpriteRenderer spriteRenderer;
    
    public AudioClip soundClip; 
    private AudioSource audioSource;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            originalSprite = spriteRenderer.sprite; 
        }

        audioSource = gameObject.AddComponent<AudioSource>();
        if (soundClip != null)
        {
            audioSource.clip = soundClip;
            audioSource.loop = true; 
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Black") 
        {
            if (spriteRenderer != null && newSprite != null)
            {
                spriteRenderer.sprite = newSprite;
            }

            if (!audioSource.isPlaying && soundClip != null)
            {
                audioSource.Play();
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Black") 
        {
            if (spriteRenderer != null)
            {
                spriteRenderer.sprite = originalSprite;
            }

            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
