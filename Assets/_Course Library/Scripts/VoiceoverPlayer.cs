using UnityEngine;

public class VoiceoverPlayer : MonoBehaviour
{
    public AudioSource voiceOverAudio;

    
    public void PlayVoiceOver()
    {
      
        AudioSource[] allAudioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource source in allAudioSources)
        {
            if (source.isPlaying)
            {
                source.Stop();
            }
        }

        
        if (voiceOverAudio != null)
        {
            voiceOverAudio.Play();
        }
    }
}
