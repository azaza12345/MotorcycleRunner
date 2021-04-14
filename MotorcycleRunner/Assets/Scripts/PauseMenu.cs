using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    public static bool isGamePaused = false;

    void Update()
    {
        
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        isGamePaused = false;
        pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        isGamePaused = true;
        pausePanel.SetActive(false);
    }

    public void LoadMenu()
    {
        int menuIndexScene = 0;
        SceneManager.LoadScene(menuIndexScene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
