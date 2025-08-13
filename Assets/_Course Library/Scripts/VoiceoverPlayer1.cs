using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceoverPlayer1 : MonoBehaviour
{
    public AudioSource voiceOverAudio;

    // Static reference to track the currently playing voiceover
    private static AudioSource currentlyPlayingAudio;

    public void PlayVoiceOver()
    {
        // Stop the previous audio if it's playing
        if (currentlyPlayingAudio != null && currentlyPlayingAudio.isPlaying)
        {
            currentlyPlayingAudio.Stop();
        }

        // Play this one
        if (voiceOverAudio != null)
        {
            voiceOverAudio.Play();
            currentlyPlayingAudio = voiceOverAudio;
        }
    }
}
