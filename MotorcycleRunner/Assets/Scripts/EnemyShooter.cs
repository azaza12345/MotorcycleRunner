using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyShooter : EnemyController
{
    [SerializeField] private float appearanceTime;
    [Header("Shooting")]
    [SerializeField] private BulletEnemy bulletPrefab;
    [SerializeField] private Transform gun;
    [SerializeField] private float minShootDelay;
    [SerializeField] private float maxShootDelay;
    
    private bool isAppearance = true;
    private float timeToShoot;

    private IEnumerator Start()
    {
        Invoke("StopAppearance", appearanceTime);
        while (true)
        {
            timeToShoot = Random.Range(minShootDelay, maxShootDelay);

            yield return new WaitForSeconds(timeToShoot);
            Instantiate(bulletPrefab, gun.position, bulletPrefab.transform.rotation);
        }    
    }

    private void FixedUpdate()
    {
        if (isAppearance)
            MoveHorizontal();
        else
            MoveVertical();
    }

    private void MoveHorizontal()
    {
        transform.Translate(-enemySpeed * Time.deltaTime, 0f, 0f);
    }
    private void MoveVertical()
    {
        
    }
    private void StopAppearance()
    {
        isAppearance = false;
    }
}
