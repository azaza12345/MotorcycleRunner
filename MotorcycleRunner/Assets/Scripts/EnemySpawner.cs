using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyController[] enemies;
    [SerializeField] private float delayBetweenSpawn;
    [SerializeField] private float spawnArea;

    private IEnumerator Start()
    {
        while (true)
        {
            int randomEnemyIndex = UnityEngine.Random.Range(0, enemies.Length);
            float ySpawnPosition = UnityEngine.Random.Range(-spawnArea, spawnArea);
            Vector2 spawnPosition = new Vector2(transform.position.x, ySpawnPosition);
            
            yield return new WaitForSeconds(delayBetweenSpawn);
            Instantiate(enemies[randomEnemyIndex], spawnPosition, Quaternion.identity);

        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, new Vector2(1.5f, spawnArea));
    }
}
