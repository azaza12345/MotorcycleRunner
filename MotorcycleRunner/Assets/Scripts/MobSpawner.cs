using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawner : MonoBehaviour
{
    [SerializeField] private MobController[] mobs;
    [SerializeField] private float minTimeBetweenSpawn;
    [SerializeField] private float maxTimeBetweenSpawn;

    public float speed;

    private IEnumerator Start()
    {
        while (true)
        {
            var timeBetweenSpawn = Random.Range(minTimeBetweenSpawn, maxTimeBetweenSpawn);
            var randomMob = Random.Range(0, mobs.Length);

            //Instantiate new house as child for HousesSpawner
            var house = Instantiate(mobs[randomMob], transform.position, Quaternion.identity);
            house.transform.parent = transform;

            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }

}
