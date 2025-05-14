using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject pausePanel;
    public GameObject continueButton;
    public GameObject homeButton;
    public GameObject restartButton;

    public void OnPauseHandler()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }
    public void OnHomeButtonHandler()
    {
        SceneManager.LoadScene(0);
    }
    public void OnContinueButtonHandler()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
    public void OnRestartButtonHandler()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
