using UnityEngine;
using TMPro;

public class ResultsPanelManager : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text resultsText;
    public GameObject proceedButton;
    public GameObject restartButton;

    [Header("Sounds")]
    public AudioClip victorySound;
    public AudioClip defeatSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        ShowResults(QuestionPanelController.correctAnswerCount);
    }

    public void ShowResults(int score)
    {
        if (resultsText != null)
            resultsText.text = $"You got {score}/5 correct. Congrats you are done!!";

        if (score >= 3)
        {
            if (victorySound != null && audioSource != null)
                audioSource.PlayOneShot(victorySound);

            if (proceedButton != null) proceedButton.SetActive(true);
            if (restartButton != null) restartButton.SetActive(false);
        }
        else
        {
            if (defeatSound != null && audioSource != null)
                audioSource.PlayOneShot(defeatSound);

            if (proceedButton != null) proceedButton.SetActive(false);
            if (restartButton != null) restartButton.SetActive(true);
        }

        // Reset score so next quiz starts fresh
        QuestionPanelController.correctAnswerCount = 0;
    }
}
