using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartQuiz()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
