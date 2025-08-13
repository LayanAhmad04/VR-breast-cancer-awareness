using UnityEngine;

public class PanelAudioTrigger : MonoBehaviour
{
    private AudioSource audioSource;

    void OnEnable()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}