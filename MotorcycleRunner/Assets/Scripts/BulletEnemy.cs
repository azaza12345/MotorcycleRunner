using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10;
    [SerializeField] private float bound = 10;
    [SerializeField] private int bulletDamage = 10;

    private GameManager gameManager;
    private Rigidbody2D bulletRb;
    private PlayerHealth player;

    private void Start()
    {
        player = FindObjectOfType<PlayerHealth>();
        bulletRb = GetComponent<Rigidbody2D>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        MoveBullet();
    }

    // Makes bullet fly straight right
    private void MoveBullet()
    {
        bulletRb.velocity = Vector2.left * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>())
        {
            Destroy(gameObject);
            PlayerHealth player = other.gameObject.GetComponent<PlayerHealth>();
            if (player)
            {
                player.TakeDamage(bulletDamage);
                Destroy(gameObject);
            }
        }
    }
}
