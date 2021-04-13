using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health;
    private GameManager gameManager;
    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        gameManager.UpdateHealthText(health);
        
    }
    public void TakeDamage(int damage)
    {
        health = Mathf.Max(0, health - damage);
        gameManager.UpdateHealthText(health);
        
        if (health == 0)
            Death();
    }

    private void Death()
    {
        gameManager.GameOver();
    }
}
