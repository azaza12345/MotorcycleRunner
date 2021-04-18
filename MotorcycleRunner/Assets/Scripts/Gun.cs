using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private int maxMagazineCount;
    [SerializeField] private int magazineCount;
    [SerializeField] private bool magazineIsEmpty;
    
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private Transform gun;

    private Animator playerAnimator;

    private void Start()
    {
        playerAnimator = GetComponent<Animator>();
        magazineCount = maxMagazineCount;
        magazineIsEmpty = false;
    }

    private void Update()
    {
        ShootingMethods();
    }

    // Reload gun's magazine
    private IEnumerator ReloadMagazineRoutine()
    {
        yield return new WaitForSeconds(2);
        magazineCount = maxMagazineCount;
        magazineIsEmpty = false;
    }

    // Shoots when Space button is pressed (soon will change it on button)
    // When gun's magazine is Empty, reload the gun
    private void ShootingMethods()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !magazineIsEmpty)
        {
            StartCoroutine(Shoot());
        }
        
        if (magazineCount == 0)
        {
            magazineIsEmpty = true;
            StartCoroutine(ReloadMagazineRoutine());
        }
    }

    private IEnumerator Shoot()
    {
        playerAnimator.SetTrigger("Shoot_trigger");
        yield return new WaitForSeconds(0.3f);
        Instantiate(bulletPrefab, gun.position, bulletPrefab.transform.rotation);
        magazineCount--;
    }

}
