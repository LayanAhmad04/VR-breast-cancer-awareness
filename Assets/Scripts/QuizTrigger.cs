using UnityEngine;

public class QuizTrigger : MonoBehaviour
{
    [Header("Assign the instruction panel GameObject here")]
    public GameObject instructionPanel;

    private bool hasTriggered = false; // 🔹 NEW: To prevent multiple activations

    private void Start()
    {
        if (instructionPanel != null)
        {
            instructionPanel.SetActive(false);
        }
        else
        {
            Debug.LogWarning("Instruction Panel not assigned in TriggerQuiz script.");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasTriggered && other.CompareTag("Player"))
        {
            hasTriggered = true; // 🔹 Set flag so this runs only once

            Debug.Log("Player entered trigger zone."); // for testing

            if (instructionPanel != null)
            {
                instructionPanel.SetActive(true);
            }
        }
    }
}
