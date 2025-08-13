using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShowImageOnClick : MonoBehaviour
{
    public GameObject screenImage;   // The image or panel to show
    public AudioSource audioSource;  // The audio to play

    private XRBaseInteractable interactable;

    private bool hasActivated = false;

    void Awake()
    {
        interactable = GetComponent<XRBaseInteractable>();
        interactable.selectEntered.AddListener(OnSelect);
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        if (!hasActivated)
        {
            if (screenImage != null)
                screenImage.SetActive(true);

            if (audioSource != null && !audioSource.isPlaying)
                audioSource.Play();

            hasActivated = true;
        }
    }

    private void OnDestroy()
    {
        interactable.selectEntered.RemoveListener(OnSelect);
    }
}

