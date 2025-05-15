using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public string SceneName;

    public void BotStart()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void BotExit()
    {
        Application.Quit();
    }
}
