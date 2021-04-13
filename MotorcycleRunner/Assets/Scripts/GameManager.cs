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

    [SerializeField] private GameObject gameOverPanel;

    [SerializeField] private int score;
    [SerializeField] private int record;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void StartGame()
    {
        if (gameOverPanel.activeSelf) 
        { 
            gameOverPanel.SetActive(false); 
        }

        score = 0;
        UpdateScore(0);
    }

    public void UpdateHealthText(int health)
    {
        healthText.text = $"Health: {health}";
    }

    public void UpdateScore(int scoreToAdd)
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
