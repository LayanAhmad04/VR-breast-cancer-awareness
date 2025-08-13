using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestionPanelController : MonoBehaviour
{
    [Header("Quiz Setup")]
    public TMP_Text feedbackText;
    public int correctButtonIndex;
    public Button[] answerButtons;
    public GameObject nextQuestionPanel;

    [Header("Final Question Settings")]
    public bool isLastQuestion = false;
    public GameObject resultsPanel;
    public TMP_Text resultsText;
    public GameObject proceedButton;
    public GameObject restartButton;

    [Header("Answer Sounds")]
    public AudioClip correctSound;
    public AudioClip wrongSound;

    [Header("Buttons Panel Manager")]
    public ButtonsPanelManager buttonsPanelManager;  // Assign the manager here

    private AudioSource audioSource;
    private bool answered = false;
    public static int correctAnswerCount = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (feedbackText != null)
            feedbackText.text = "";

        for (int i = 0; i < answerButtons.Length; i++)
        {
            int index = i;
            answerButtons[i].interactable = true;
            answerButtons[i].onClick.RemoveAllListeners();
            answerButtons[i].onClick.AddListener(() => OnAnswerSelected(index));
        }

        if (proceedButton != null) proceedButton.SetActive(false);
        if (restartButton != null) restartButton.SetActive(false);
        if (resultsPanel != null) resultsPanel.SetActive(false);
    }

    void OnEnable()
    {
        answered = false;

        if (feedbackText != null)
            feedbackText.text = "";

        foreach (var btn in answerButtons)
            btn.interactable = true;

        if (proceedButton != null) proceedButton.SetActive(false);
        if (restartButton != null) restartButton.SetActive(false);
        if (resultsPanel != null) resultsPanel.SetActive(false);
    }

    public void OnAnswerSelected(int selectedIndex)
    {
        if (answered) return;
        answered = true;

        bool isCorrect = selectedIndex == correctButtonIndex;

        Debug.Log($"Question: {gameObject.name} | Selected: {selectedIndex} | Expected: {correctButtonIndex} | Correct: {isCorrect}");

        if (isCorrect)
        {
            feedbackText.text = "Correct!";
            correctAnswerCount++;
            Debug.Log($"CorrectAnswerCount is now {correctAnswerCount}");
            if (correctSound != null && audioSource != null)
                audioSource.PlayOneShot(correctSound);
        }
        else
        {
            feedbackText.text = "Wrong!";
            if (wrongSound != null && audioSource != null)
                audioSource.PlayOneShot(wrongSound);
        }

        foreach (var btn in answerButtons)
            btn.interactable = false;

        StartCoroutine(SwitchToNextPanel());
    }



    private IEnumerator SwitchToNextPanel()
    {
        yield return new WaitForSeconds(2f);

        if (isLastQuestion)
        {
            ShowFinalResults();
        }
        else if (nextQuestionPanel != null)
        {
            nextQuestionPanel.SetActive(true);
        }

        gameObject.SetActive(false);
    }

    private void ShowFinalResults()
    {
        if (resultsPanel != null)
        {
            resultsPanel.SetActive(true);

            if (buttonsPanelManager != null)
                buttonsPanelManager.ShowButtonsForSeconds(20f);

            resultsText.text = $"You got {correctAnswerCount}/5 correct.";

            if (correctAnswerCount >= 3)
            {
                proceedButton.SetActive(true);
                restartButton.SetActive(false);
            }
            else
            {
                proceedButton.SetActive(false);
                restartButton.SetActive(true);
            }

         //   correctAnswerCount = 0;
        }
        else
        {
            Debug.LogWarning("Results panel not assigned.");
        }
    }
}