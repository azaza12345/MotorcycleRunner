using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10;

    private Rigidbody2D bulletRb;

    private void Start()
    {
        bulletRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveBullet();
    }

    // Makes bullet fly straight right
    private void MoveBullet()
    {
        bulletRb.velocity = Vector2.right * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<EnemyController>())
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
