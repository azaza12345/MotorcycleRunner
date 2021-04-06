using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10;
    [SerializeField] private float bound = 10;
    private Rigidbody2D bulletRb;

    private void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveBullet();
        DestroyOutOfBounds();
    }

    // Makes bullet fly straight right
    private void MoveBullet()
    {
        bulletRb.velocity = Vector2.right * bulletSpeed;
    }

    // If bullet is out of bounds, destroys it
    private void DestroyOutOfBounds()
    {
        if (transform.position.x < -bound | transform.position.x > bound)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<EnemyController>())
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
