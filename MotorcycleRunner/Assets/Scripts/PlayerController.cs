using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    private Rigidbody2D playerRb;
    private Vector2 move;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
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

}
