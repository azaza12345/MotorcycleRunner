using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private int magazineCount;
    [SerializeField] private bool magazineIsEmpty;
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private Transform gun;

    private int maxMagazineCount = 15;

    void Start()
    {
        magazineCount = maxMagazineCount;
        magazineIsEmpty = false;
    }

    void Update()
    {
        Shooting();
    }

    // Reload gun's magazine
    IEnumerator ReloadMagazineRoutine()
    {
        yield return new WaitForSeconds(2);
        magazineCount = maxMagazineCount;
        magazineIsEmpty = false;
    }

    // Shoots when Space button is pressed (soon will change it on button)
    // When gun's magazine is Empty, reload the gun
    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !magazineIsEmpty)
        {
            Instantiate(bulletPrefab, gun.position, bulletPrefab.transform.rotation);
            magazineCount--;
        }
        
        if (magazineCount == 0)
        {
            magazineIsEmpty = true;
            StartCoroutine(ReloadMagazineRoutine());
        }
    }

}
