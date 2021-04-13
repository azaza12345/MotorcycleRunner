using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public int health;
    [SerializeField] private float speed = 5;

    private GameManager gameManager;

    private Rigidbody2D playerRb;
    private Vector2 move;

    private int enemy1Damage = 50;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();

        health = 100;
        gameManager.UpdateHealthText(health);
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Moves player based on arrow key input (soon will make joystick)
    private void MovePlayer()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        playerRb.velocity = move * speed;
    }

    // When Player collides with other objects
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>())
        {
            Destroy(collision.gameObject);
            UpdateHealth(-enemy1Damage);
        }
    }

    public void UpdateHealth(int healthToAdd)
    {
        health += healthToAdd;
        gameManager.UpdateHealthText(health);

        if (health <= 0)
        {
            gameManager.GameOver();
        }
    }

}
