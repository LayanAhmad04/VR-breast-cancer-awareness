using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTeleporter : MonoBehaviour
{
    public string sceneName; 

    public void TeleportToScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
