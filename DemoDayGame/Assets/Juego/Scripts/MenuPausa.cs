using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject PanelPausa;
    private bool EnPausa = false;

    public string SceneName;

    void Start()
    {
        PanelPausa.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (EnPausa)
            {
                Reanudar();
            }
            else
            {
                Pausa();
            }
        }
    }

    public void Pausa()
    {
        PanelPausa.SetActive(true);
        Time.timeScale = 0f;
        EnPausa = true;
    }

    public void Reanudar()
    {
        PanelPausa.SetActive(false);
        Time.timeScale = 1f;
        EnPausa = false;
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneName);
    }

    public void MenuInicio()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Inicio");
    }

    public void BotExit()
    {
        Application.Quit();
    }
}
