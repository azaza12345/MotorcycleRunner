using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Death")]
    [SerializeField] private int enemyScore = 5; 
    [SerializeField] private int collidingDamage;

    [Header("Moving")]
    [SerializeField] protected float enemySpeed = 3;

    private GameManager gameManager;
    protected Rigidbody2D enemyRb;
    protected Vector2 move;
    protected PlayerHealth player;

    private void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
        enemyRb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    // When Enemy collides with other Player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth player = collision.gameObject.GetComponent<PlayerHealth>();
        if (player)
        {
            player.TakeDamage(collidingDamage);
            Destroy(gameObject);
        }
    }

    public void OnDestroy()
    {
        // Enemy death animation
        // gameManager.UpdateScoreText(enemyScore);

        if (gameManager) { Debug.Log("wtf"); }
    }
}