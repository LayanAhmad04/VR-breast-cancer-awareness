using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class UIButtonSoundPlayer : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource audioSource;

    void Awake()
    {
        // Use the AudioSource from the main camera if available
        audioSource = Camera.main.GetComponent<AudioSource>();

        // Fallback: create an AudioSource on this GameObject if needed
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            Debug.LogWarning("No AudioSource found on Main Camera. Created one on this button.");
        }

        // Add click listener to the button
        GetComponent<Button>().onClick.AddListener(PlayClickSound);
    }

    private void PlayClickSound()
    {
        if (clickSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}
