using UnityEngine;

public class PosterAudioController : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void OnSelect()
    {
        if (AudioManager.Instance.IsCurrent(audioSource))
        {
            AudioManager.Instance.TogglePauseResume(audioSource);
        }
        else
        {
            AudioManager.Instance.PlayAudio(audioSource);
        }
    }
}
