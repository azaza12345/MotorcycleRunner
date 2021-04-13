using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 3;
    [SerializeField] private int enemyScore = 5;
    [SerializeField] private int collidingDamage;

    private GameManager gameManager;
    private Rigidbody2D enemyRb;
    private Vector2 move;
    private PlayerHealth player;

    private void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
        enemyRb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void FixedUpdate() 
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        move = (player.transform.position - transform.position).normalized;
        enemyRb.velocity = move * enemySpeed;
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

    private void OnDestroy()
    {
        gameManager.UpdateScore(enemyScore);   
    }
}