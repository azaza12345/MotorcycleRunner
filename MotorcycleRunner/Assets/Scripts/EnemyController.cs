using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D enemyRb;
    private GameObject player;
    private Vector2 move;

    [SerializeField] private float enemySpeed = 3;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    void FixedUpdate() 
    {
        MoveEnemy();
    }

    void MoveEnemy()
    {
        move = (player.transform.position - transform.position).normalized;
        enemyRb.velocity = move * enemySpeed;
    }
}