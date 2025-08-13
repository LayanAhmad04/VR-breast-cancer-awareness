using UnityEngine;

public class PosterAudio : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
    }
}
