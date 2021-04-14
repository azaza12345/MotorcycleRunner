using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class HousesSpawner : MonoBehaviour
{
    [SerializeField] private House[] houses;
    [SerializeField] private float minTimeBetweenSpawn;
    [SerializeField] private float maxTimeBetweenSpawn;
    public float speed; //using it in a script House.cs

    private IEnumerator Start()
    {
        while (true)
        {
            var timeBetweenSpawn = Random.Range(minTimeBetweenSpawn, maxTimeBetweenSpawn);
            var randomHouse = Random.Range(0, houses.Length);
            
            //Instantiate new house as child for HousesSpawner
            var house = Instantiate(houses[randomHouse], transform.position, Quaternion.identity);
            house.transform.parent = transform;

            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
}
