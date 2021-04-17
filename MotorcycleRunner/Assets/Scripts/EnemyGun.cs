using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    [SerializeField] private BulletEnemy bulletPrefab;
    [SerializeField] private Transform gun;

    [SerializeField] private int bulletsToSpawn = 1;
    [SerializeField] private float bulletRotation = 10;

    private float timeToShoot;

    private IEnumerator Start()
    {
        while (true)
        {
            if (bulletsToSpawn == 1)
            {
                timeToShoot = Random.Range(0.5f, 1.5f);

                yield return new WaitForSeconds(timeToShoot);
                Instantiate(bulletPrefab, gun.position, bulletPrefab.transform.rotation);
            }
            else
            {
                timeToShoot = Random.Range(1.5f, 3f);

                yield return new WaitForSeconds(timeToShoot);
                Instantiate(bulletPrefab, gun.position, bulletPrefab.transform.rotation);
                Instantiate(bulletPrefab, gun.position, Quaternion.Euler(RotateBullet()));
                Instantiate(bulletPrefab, gun.position, Quaternion.Euler(RotateBullet()));
            }

            
        }    
    }

    private Vector3 RotateBullet()
    {
        float rotation = Random.Range(-bulletRotation, bulletRotation);

        return new Vector3(0, 0, rotation);
    }

}
