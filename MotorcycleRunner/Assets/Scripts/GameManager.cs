using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverPanel;

    [SerializeField] private int score;

    private void StartGame()
    {
        score = 0;
        UpdateScore(0);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = $"Score: {score}";
    }

    //public void GameOver()
    //{
    //    gameOverPanel.SetActive(true);
    //    Time.timeScale = 0;
    //}
}
