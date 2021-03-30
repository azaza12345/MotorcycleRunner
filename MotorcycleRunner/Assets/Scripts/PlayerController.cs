using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float topBound = 0.5f;
    private float bottomBound = -4.5f;
    private float leftBound = -9;
    private float rightBound = 5;

    private bool gameOver = false;

    [SerializeField] private float speed = 10;
    [SerializeField] private int health = 100;

    void Start()
    {
        
    }

    void Update()
    {
        ConstrainPlayerPosition();
        MovePlayer();
    }

    // Moves player based on arrow key input (soon will make joystick)
    void MovePlayer() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0);
    }

    // Prevents player to move out of the bounds
    void ConstrainPlayerPosition()
    {
        if (transform.position.y > topBound) { transform.position = new Vector2(transform.position.x, topBound); }
        if (transform.position.y < bottomBound) { transform.position = new Vector2(transform.position.x, bottomBound); }
        if (transform.position.x > rightBound) { transform.position = new Vector2(rightBound, transform.position.y); }
        if (transform.position.x < leftBound) { transform.position = new Vector2(leftBound, transform.position.y); }
    }

}
