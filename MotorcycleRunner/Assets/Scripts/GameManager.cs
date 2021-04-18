using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI recordText;
    [SerializeField] private TextMeshProUGUI healthText;

    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject gameOverPanel;

    [SerializeField] private int score;
    [SerializeField] private int record;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void UpdateHealthText(int health)
    {
        healthText.text = $"Health: {health}";
    }

    public void UpdateScoreText(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = $"Score: {score}";
    }

    public void GameOver()
    {
        if (score > record)
        {
            record = score;
        }

        recordText.text = $"Record: {record}";

        pauseButton.SetActive(false);
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;       
    }

    public void ReloadScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(0);
    }
}
