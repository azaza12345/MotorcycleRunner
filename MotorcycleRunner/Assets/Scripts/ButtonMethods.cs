using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMethods : MonoBehaviour
{
    [SerializeField] private GameObject aboutPanel;
    [SerializeField] private GameObject settingsPanel;

    private int currentScene;

    private void Start()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void OpenAboutPanel()
    {
        aboutPanel.SetActive(true);
    }

    public void OpenSettingsPanel()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseAboutPanel()
    {
        aboutPanel.SetActive(false);
    }

    public void CloseSettingsPanel()
    {
        settingsPanel.SetActive(false);
    }
}
