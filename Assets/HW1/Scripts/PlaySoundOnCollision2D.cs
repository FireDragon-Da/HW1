using UnityEngine;

public class PlaySoundOnCollision2D : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Black") 
        {
            if (!audioSource.isPlaying) 
            {
                audioSource.Play();
            }
        }
    }
}
