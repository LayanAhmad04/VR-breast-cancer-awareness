using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceoverController : MonoBehaviour
{
    public AudioSource voiceOver1;
    public AudioSource voiceOver2;
    public GameObject bodyModel;

    void Start()
    {
        bodyModel.SetActive(false); // Make sure it's hidden initially
        voiceOver1.Play();
        StartCoroutine(PlaySecondVoiceoverAfterFirst());
    }

    System.Collections.IEnumerator PlaySecondVoiceoverAfterFirst()
    {
        yield return new WaitForSeconds(voiceOver1.clip.length);

        bodyModel.SetActive(true);
        voiceOver2.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
