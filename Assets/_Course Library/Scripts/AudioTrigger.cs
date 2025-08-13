using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource thisAudio;

    public void PlayMyAudio()
    {
        AudioManager.Instance.PlayAudio(thisAudio);
    }
}
