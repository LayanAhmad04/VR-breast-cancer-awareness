using UnityEngine;

public class Exit : MonoBehaviour
{
    // This method can be linked to the button's OnClick event in the Inspector
    public void ExitGame()
    {
        Debug.Log("Exit button pressed. Quitting the game...");

        // Quit the application
        Application.Quit();

        // If running in the Unity Editor, this line is needed for testing
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
