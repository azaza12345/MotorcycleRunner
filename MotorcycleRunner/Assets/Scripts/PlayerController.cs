using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;
    [SerializeField] private int health = 100;

    private GameManager gameManager;

    private Rigidbody2D myRigidBody;
    private Vector2 move;

    private void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void FixedUpdate()
    {
        MovePlayer();

        //if (health <= 0)
        //{
        //    gameManager.GameOver();
        //}
    }

    // Moves player based on arrow key input (soon will make joystick)
    private void MovePlayer()
    {
        move.x = Input.GetAxis("Horizontal");
        move.y = Input.GetAxis("Vertical");

        myRigidBody.velocity = move * speed;
    }

    // When Player collides with other objects
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<EnemyController>())
        {
            Destroy(collision.gameObject);
            health = 0;
        }
    }

}
