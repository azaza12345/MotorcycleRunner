using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D bulletRb;

    private float bulletSpeed = 10;
    private float bound = 10;

    void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveBullet();
        DestroyOutOfBounds();
    }

    // Makes bullet fly straight right
    void MoveBullet()
    {
        bulletRb.velocity = Vector2.right * bulletSpeed;
    }

    // If bullet is out of bounds, destroys it
    void DestroyOutOfBounds()
    {
        if (transform.position.x < -bound | transform.position.x > bound)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("doesn't work");
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
