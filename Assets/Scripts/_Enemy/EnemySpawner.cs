using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 1.0f;
    public float spawnDuration = 10.0f;

    private float timer = 0.0f;
    private int currentEnemyType = 0;
    private float currentEnemyDuration = 0.0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0.0f;

            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            GameObject enemyPrefab = enemyPrefabs[currentEnemyType];
            Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

            currentEnemyDuration += spawnInterval;

            if (currentEnemyDuration >= spawnDuration)
            {
                currentEnemyType = (currentEnemyType + 1) % enemyPrefabs.Length;
                currentEnemyDuration = 0.0f;
            }
        }
    }
}
