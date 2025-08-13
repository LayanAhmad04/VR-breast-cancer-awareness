using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UIButtonClickSound : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource audioSource;

    void Awake()
    {
        audioSource = Camera.main.GetComponent<AudioSource>(); // Or assign a central audio source
        if (audioSource == null)
        {
            Debug.LogWarning("No AudioSource found on Main Camera. Add one or assign manually.");
        }

        GetComponent<Button>().onClick.AddListener(PlayClickSound);
    }

    void PlayClickSound()
    {
        if (clickSound != null && audioSource != null)
            audioSource.PlayOneShot(clickSound);
    }
}
