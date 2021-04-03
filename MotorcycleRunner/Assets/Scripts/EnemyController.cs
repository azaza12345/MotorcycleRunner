using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 3;
    private Rigidbody2D enemyRb;
    private Vector2 move;
    private PlayerController player;

    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        enemyRb = GetComponent<Rigidbody2D>();
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
}