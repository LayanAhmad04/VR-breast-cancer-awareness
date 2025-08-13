using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    private AudioSource currentPlaying;
    private bool isPaused = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void PlayAudio(AudioSource newAudio)
    {
        if (currentPlaying != null && currentPlaying != newAudio)
        {
            currentPlaying.Stop();
            isPaused = false;
        }

        currentPlaying = newAudio;
        isPaused = false;
        currentPlaying.Play();
    }

    public void TogglePauseResume(AudioSource source)
    {
        if (source == currentPlaying)
        {
            if (!isPaused && source.isPlaying)
            {
                source.Pause();
                isPaused = true;
            }
            else if (isPaused)
            {
                source.UnPause();
                isPaused = false;
            }
        }
    }

    public bool IsCurrent(AudioSource source)
    {
        return currentPlaying == source;
    }

    public bool IsPaused()
    {
        return isPaused;
    }
}
